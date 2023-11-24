namespace Encapsulation;

public class StateConsumer
{
    public void PrintState()
    {
        // Ошибка DefaultState - по умолчанию internal, поэтому нет доступа
        //DefaultState defaultState = new DefaultState();

        // Ошибка InternalState - internal, поэтому нет доступа
        //InternalState internalState = new PublicState.InternalState();

        // норм, PublicState - public, доступен из других программ
        PublicState publicState = new PublicState();

        // Ошибка, нет доступа - метод доступен только в свой сборке
        publicState.PrintInternal();

        // Ошибка, нет доступа - StateConsumer НЕ является классом-наследником от класса PublicState,
        // поэтому метод не доступен
        publicState.PrintProtectedInternal(); // нет доступа
        
        // норм - общедоступный метод
        publicState.PrintPublic(); // норм
    }
}