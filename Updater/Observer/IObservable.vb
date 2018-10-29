Public Interface IObservable
    Sub Register(ByVal xObserver As IObserver)
    Sub UnRegister(ByVal xObserver As IObserver)
    Sub notifyObservers()
    Sub notifyObservers(ByVal xData As Object)
End Interface
