using System;
using System.Collections;
using System.Reflection;
using System.Runtime.CompilerServices;

// Token: 0x02000004 RID: 4
[NullableContext(1)]
[Nullable(0)]
public class HashSetPropertyConverter
{
	// Token: 0x06000004 RID: 4 RVA: 0x00002174 File Offset: 0x00000374
	public unsafe static IEnumerable ReadParameterBuffer(ScriptPropertyDefine propertyDefine, [Nullable(0)] byte* buffer, ref int offset, Type type)
	{
		Type type2 = type.GetGenericArguments()[0];
		IEnumerable enumerable = (IEnumerable)Activator.CreateInstance(type);
		MethodInfo method = type.GetMethod("Add");
		if (enumerable == null || method == null)
		{
			throw new Exception("HashSetPropertyConverter.ReadParameterBuffer Dictionary is null");
		}
		if (propertyDefine.ElementCount == 0)
		{
			return enumerable;
		}
		if (propertyDefine.HeadElementProperty0 == null)
		{
			throw new Exception("HashSetPropertyConverter.ReadParameterBuffer HeadElementProperty is null");
		}
		bool flag = propertyDefine.HeadElementProperty0.IsContainerType();
		for (int i = 0; i < propertyDefine.ElementCount; i++)
		{
			ScriptPropertyDefine propertyDefine2 = (flag && i > 0) ? propertyDefine.ElementProperty0[i - 1] : propertyDefine.HeadElementProperty0;
			method.Invoke(enumerable, new object[]
			{
				GameScriptPropertyConverterUtils.ReadParameterBufferToObject(propertyDefine2, buffer, ref offset, type2)
			});
		}
		return enumerable;
	}

	// Token: 0x06000005 RID: 5 RVA: 0x00002230 File Offset: 0x00000430
	public unsafe static void WriteParameterBuffer(ScriptPropertyDefine propertyDefine, in object value, [Nullable(0)] byte* buffer, ref int offset, Type type)
	{
		Type type2 = type.GetGenericArguments()[0];
		IEnumerable enumerable = (IEnumerable)value;
		if (enumerable == null || propertyDefine.HeadElementProperty0 == null)
		{
			throw new NotImplementedException();
		}
		bool flag = propertyDefine.HeadElementProperty0.IsContainerType();
		if (propertyDefine.ElementCount > 0)
		{
			int num = 0;
			foreach (object obj in enumerable)
			{
				GameScriptPropertyConverterUtils.WriteParameterBufferFromObject((flag && num > 0) ? propertyDefine.ElementProperty0[num - 1] : propertyDefine.HeadElementProperty0, obj, buffer, ref offset, type2);
				num++;
			}
		}
	}
}
