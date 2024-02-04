import express, { type Router } from 'express'
import { addTransaction, getTransaction, getTransactionById, getTransactionByAnyting, getTransactions } from '../controller/transaction.controller'
import { authentication } from '../middleware/auth'

const transactionRouter: Router = express.Router()

// Web
transactionRouter.post('/transaction/add', authentication, addTransaction)
transactionRouter.get('/transaction/get/', getTransactions)
transactionRouter.get('/transaction/get/:id', authentication, getTransaction)
transactionRouter.get('/transaction/get/product/:userId', authentication, getTransactionByAnyting)
transactionRouter.get('/transaction/get/:transactionId/:userId', authentication, getTransactionById)

// Desktop
transactionRouter.post('/desktop/transaction/add', addTransaction)
transactionRouter.get('/desktop/transaction/get/', getTransactions)
transactionRouter.get('/desktop/transaction/get/:id', getTransaction)
transactionRouter.get('/desktop/transaction/get/product/:userId', getTransactionByAnyting)
transactionRouter.get('/desktop/transaction/get/:transactionId/:userId', getTransactionById)

export default transactionRouter