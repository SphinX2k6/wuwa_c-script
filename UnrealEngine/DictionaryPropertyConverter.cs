using System;
using System.Collections;
using System.Runtime.CompilerServices;

// Token: 0x02000005 RID: 5
[NullableContext(1)]
[Nullable(0)]
public class DictionaryPropertyConverter
{
	// Token: 0x06000007 RID: 7 RVA: 0x000022F0 File Offset: 0x000004F0
	public unsafe static IEnumerable ReadParameterBuffer(ScriptPropertyDefine propertyDefine, [Nullable(0)] byte* buffer, ref int offset, Type type)
	{
		Type[] genericArguments = type.GetGenericArguments();
		Type type2 = genericArguments[0];
		Type type3 = genericArguments[1];
		IDictionary dictionary = (IDictionary)Activator.CreateInstance(type);
		if (dictionary == null)
		{
			throw new Exception("DictionaryPropertyConverter.ReadParameterBuffer Dictionary is null");
		}
		if (propertyDefine.ElementCount == 0)
		{
			return dictionary;
		}
		if (propertyDefine.HeadElementProperty0 == null || propertyDefine.HeadElementProperty1 == null)
		{
			throw new Exception("DictionaryPropertyConverter.ReadParameterBuffer HeadElementProperty is null");
		}
		bool flag = propertyDefine.HeadElementProperty0.IsContainerType();
		bool flag2 = propertyDefine.HeadElementProperty1.IsContainerType();
		for (int i = 0; i < propertyDefine.ElementCount; i++)
		{
			ScriptPropertyDefine propertyDefine2 = (flag && i > 0) ? propertyDefine.ElementProperty0[i - 1] : propertyDefine.HeadElementProperty0;
			ScriptPropertyDefine propertyDefine3 = (flag2 && i > 0) ? propertyDefine.ElementProperty1[i - 1] : propertyDefine.HeadElementProperty1;
			object obj = GameScriptPropertyConverterUtils.ReadParameterBufferToObject(propertyDefine2, buffer, ref offset, type2);
			object value = GameScriptPropertyConverterUtils.ReadParameterBufferToObject(propertyDefine3, buffer, ref offset, type3);
			if (obj != null)
			{
				dictionary.Add(obj, value);
			}
		}
		return dictionary;
	}

	// Token: 0x06000008 RID: 8 RVA: 0x000023E0 File Offset: 0x000005E0
	public unsafe static void WriteParameterBuffer(ScriptPropertyDefine propertyDefine, in object value, [Nullable(0)] byte* buffer, ref int offset, Type type)
	{
		Type[] genericArguments = type.GetGenericArguments();
		Type type2 = genericArguments[0];
		Type type3 = genericArguments[1];
		IDictionary dictionary = (IDictionary)value;
		if (dictionary == null || propertyDefine.HeadElementProperty0 == null || propertyDefine.HeadElementProperty1 == null)
		{
			throw new NotImplementedException();
		}
		bool flag = propertyDefine.HeadElementProperty0.IsContainerType();
		bool flag2 = propertyDefine.HeadElementProperty1.IsContainerType();
		int num = 0;
		foreach (object obj in dictionary)
		{
			DictionaryEntry dictionaryEntry = (DictionaryEntry)obj;
			if (dictionaryEntry.Value == null)
			{
				throw new NotImplementedException();
			}
			ScriptPropertyDefine scriptPropertyDefine = (flag && num > 0) ? propertyDefine.ElementProperty0[num - 1] : propertyDefine.HeadElementProperty0;
			ScriptPropertyDefine propertyDefine2 = (flag2 && num > 0) ? propertyDefine.ElementProperty1[num - 1] : propertyDefine.HeadElementProperty1;
			ScriptPropertyDefine propertyDefine3 = scriptPropertyDefine;
			object obj2 = dictionaryEntry.Key;
			GameScriptPropertyConverterUtils.WriteParameterBufferFromObject(propertyDefine3, obj2, buffer, ref offset, type2);
			obj2 = dictionaryEntry.Value;
			GameScriptPropertyConverterUtils.WriteParameterBufferFromObject(propertyDefine2, obj2, buffer, ref offset, type3);
			num++;
		}
	}
}
