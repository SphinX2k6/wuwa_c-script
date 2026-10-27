using System;
using System.Collections;
using System.Runtime.CompilerServices;

// Token: 0x02000003 RID: 3
[NullableContext(1)]
[Nullable(0)]
public class ListPropertyConverter
{
	// Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
	public unsafe static IList ReadParameterBuffer(ScriptPropertyDefine propertyDefine, [Nullable(0)] byte* buffer, ref int offset, Type type)
	{
		Type type2 = type.GetGenericArguments()[0];
		IList list = (IList)Activator.CreateInstance(type);
		if (list == null)
		{
			throw new Exception("ListPropertyConverter.ReadParameterBuffer Dictionary is null");
		}
		if (propertyDefine.ElementCount == 0)
		{
			return list;
		}
		if (propertyDefine.HeadElementProperty0 == null)
		{
			throw new Exception("ListPropertyConverter.ReadParameterBuffer HeadElementProperty is null");
		}
		bool flag = propertyDefine.HeadElementProperty0.IsContainerType();
		for (int i = 0; i < propertyDefine.ElementCount; i++)
		{
			ScriptPropertyDefine propertyDefine2 = (flag && i > 0) ? propertyDefine.ElementProperty0[i - 1] : propertyDefine.HeadElementProperty0;
			list.Add(GameScriptPropertyConverterUtils.ReadParameterBufferToObject(propertyDefine2, buffer, ref offset, type2));
		}
		return list;
	}

	// Token: 0x06000002 RID: 2 RVA: 0x000020EC File Offset: 0x000002EC
	public unsafe static void WriteParameterBuffer(ScriptPropertyDefine propertyDefine, in object value, [Nullable(0)] byte* buffer, ref int offset, Type type)
	{
		Type type2 = type.GetGenericArguments()[0];
		IList list = (IList)value;
		if (list == null || propertyDefine.HeadElementProperty0 == null)
		{
			throw new NotImplementedException();
		}
		bool flag = propertyDefine.HeadElementProperty0.IsContainerType();
		for (int i = 0; i < propertyDefine.ElementCount; i++)
		{
			ScriptPropertyDefine propertyDefine2 = (flag && i > 0) ? propertyDefine.ElementProperty0[i - 1] : propertyDefine.HeadElementProperty0;
			object obj = list[i];
			GameScriptPropertyConverterUtils.WriteParameterBufferFromObject(propertyDefine2, obj, buffer, ref offset, type2);
		}
	}
}
