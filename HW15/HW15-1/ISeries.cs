namespace HW15_1;

public interface ISeries
{
    /// <summary>
    /// Устанавливает начальное значение
    /// </summary>
    /// <param name="x"></param>
    void SetStart(int x);
    
    /// <summary>
    /// Возвращает следующее число ряда
    /// </summary>
    /// <returns></returns>
    int GetNext();

    /// <summary>
    /// Выполняет сброс к начальному значению
    /// </summary>
    void Reset();
}
