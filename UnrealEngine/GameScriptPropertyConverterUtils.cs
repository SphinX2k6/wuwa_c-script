using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using Microsoft.CSharp.RuntimeBinder;
using UnrealEngine;
using UnrealEngine.Marshal;
using UnrealEngine.Utils;

// Token: 0x02000006 RID: 6
[NullableContext(1)]
[Nullable(0)]
public class GameScriptPropertyConverterUtils
{
	// Token: 0x0600000A RID: 10 RVA: 0x00002508 File Offset: 0x00000708
	[NullableContext(2)]
	public unsafe static bool ReadParameter<T>([Nullable(0)] byte* buffer, ref int offset, ref T result)
	{
		ScriptPropertyDefine scriptPropertyDefine = ScriptPropertyDefine.CreatePropertyDefine(buffer, ref offset);
		scriptPropertyDefine.Deserialize(buffer, ref offset);
		if (scriptPropertyDefine.Type == EScriptPropertyType.EScriptPropertyType_Undefined)
		{
			offset += sizeof(void*);
			return true;
		}
		if (scriptPropertyDefine.IsSpecialSerialize())
		{
			Type typeFromHandle = typeof(T);
			object obj = GameScriptPropertyConverterUtils.ReadParameterBufferToObject(scriptPropertyDefine, buffer, ref offset, typeFromHandle);
			if (obj == null)
			{
				return false;
			}
			result = (T)((object)obj);
			return true;
		}
		else
		{
			Type scriptPropertyType = GameScriptPropertyConverterUtils.GetScriptPropertyType(scriptPropertyDefine);
			T t;
			if (scriptPropertyType != typeof(T))
			{
				object obj2 = GameScriptPropertyConverterUtils.ReadParameterBufferToObject(scriptPropertyDefine, buffer, ref offset, scriptPropertyType);
				if (obj2 == null)
				{
					return false;
				}
				object arg = obj2;
				try
				{
					if (GameScriptPropertyConverterUtils.<>o__0<T>.<>p__0 == null)
					{
						GameScriptPropertyConverterUtils.<>o__0<T>.<>p__0 = CallSite<Func<CallSite, object, T>>.Create(Binder.Convert(CSharpBinderFlags.ConvertExplicit, typeof(T), typeof(GameScriptPropertyConverterUtils)));
					}
					t = GameScriptPropertyConverterUtils.<>o__0<T>.<>p__0.Target(GameScriptPropertyConverterUtils.<>o__0<T>.<>p__0, arg);
					goto IL_132;
				}
				catch (InvalidCastException)
				{
					string message = "[GameScriptPropertyConverterUtils]ConvertType Failed!!!";
					<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("TargetType", typeof(T));
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("ValueType", scriptPropertyType);
					UnrealLogger.Warn(message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
					return false;
				}
			}
			t = GameScriptPropertyConverterUtils.ReadParameterBuffer<T>(buffer, ref offset);
			IL_132:
			if (t == null)
			{
				return false;
			}
			result = t;
			return true;
		}
	}

	// Token: 0x0600000B RID: 11 RVA: 0x0000266C File Offset: 0x0000086C
	[NullableContext(2)]
	public unsafe static T ReadParameterBuffer<T>([Nullable(0)] byte* buffer, ref int offset)
	{
		return UnmanagedTypeMarshallingProcessor<T>.Read(buffer, ref offset);
	}

	// Token: 0x0600000C RID: 12 RVA: 0x00002678 File Offset: 0x00000878
	[NullableContext(0)]
	public unsafe static FName ReadParameterBufferToFName(byte* buffer, ref int offset)
	{
		uint comparisonIndex = UnmanagedTypeMarshallingProcessor<uint>.Read(buffer, ref offset);
		uint displayIndex = UnmanagedTypeMarshallingProcessor<uint>.Read(buffer, ref offset);
		uint number = UnmanagedTypeMarshallingProcessor<uint>.Read(buffer, ref offset);
		return new FName(comparisonIndex, displayIndex, number);
	}

	// Token: 0x0600000D RID: 13 RVA: 0x000026A4 File Offset: 0x000008A4
	[NullableContext(2)]
	public unsafe static object ReadParameterBufferToObject([Nullable(1)] ScriptPropertyDefine propertyDefine, [Nullable(0)] byte* buffer, ref int offset, Type type)
	{
		switch (propertyDefine.Type)
		{
		case EScriptPropertyType.EScriptPropertyType_Boolean:
			return UnmanagedTypeMarshallingProcessor<bool>.Read(buffer, ref offset);
		case EScriptPropertyType.EScriptPropertyType_Enum:
		case EScriptPropertyType.EScriptPropertyType_Int32:
			return UnmanagedTypeMarshallingProcessor<int>.Read(buffer, ref offset);
		case EScriptPropertyType.EScriptPropertyType_Int8:
			return UnmanagedTypeMarshallingProcessor<sbyte>.Read(buffer, ref offset);
		case EScriptPropertyType.EScriptPropertyType_UInt8:
			return UnmanagedTypeMarshallingProcessor<sbyte>.Read(buffer, ref offset);
		case EScriptPropertyType.EScriptPropertyType_Int16:
			return UnmanagedTypeMarshallingProcessor<short>.Read(buffer, ref offset);
		case EScriptPropertyType.EScriptPropertyType_UInt16:
			return UnmanagedTypeMarshallingProcessor<ushort>.Read(buffer, ref offset);
		case EScriptPropertyType.EScriptPropertyType_UInt32:
			return UnmanagedTypeMarshallingProcessor<uint>.Read(buffer, ref offset);
		case EScriptPropertyType.EScriptPropertyType_Int64:
			return UnmanagedTypeMarshallingProcessor<long>.Read(buffer, ref offset);
		case EScriptPropertyType.EScriptPropertyType_UInt64:
			return UnmanagedTypeMarshallingProcessor<ulong>.Read(buffer, ref offset);
		case EScriptPropertyType.EScriptPropertyType_Float:
			return UnmanagedTypeMarshallingProcessor<float>.Read(buffer, ref offset);
		case EScriptPropertyType.EScriptPropertyType_Double:
			return UnmanagedTypeMarshallingProcessor<double>.Read(buffer, ref offset);
		case EScriptPropertyType.EScriptPropertyType_String:
		{
			StringPropertyDefine stringPropertyDefine = (StringPropertyDefine)propertyDefine;
			if (stringPropertyDefine.IsPassByPointer)
			{
				long value = UnmanagedTypeMarshallingProcessor<long>.Read(buffer, ref offset);
				IntPtr intPtr = new IntPtr(value);
				return FString.ToString(intPtr.ToPointer());
			}
			char[] array = new char[stringPropertyDefine.StringLength];
			char[] array2;
			void* destination;
			if ((array2 = array) == null || array2.Length == 0)
			{
				destination = null;
			}
			else
			{
				destination = (void*)(&array2[0]);
			}
			uint num = (uint)(stringPropertyDefine.StringLength * 2);
			Unsafe.CopyBlock(destination, (void*)(buffer + offset), num);
			offset += (int)num;
			array2 = null;
			return new string(array);
		}
		case EScriptPropertyType.EScriptPropertyType_FArrayBuffer:
		{
			long value2 = UnmanagedTypeMarshallingProcessor<long>.Read(buffer, ref offset);
			FArrayBuffer farrayBuffer = default(FArrayBuffer);
			IntPtr intPtr2 = new IntPtr(value2);
			farrayBuffer.Data = intPtr2.ToPointer();
			farrayBuffer.Length = UnmanagedTypeMarshallingProcessor<ulong>.Read(buffer, ref offset);
			return farrayBuffer;
		}
		case EScriptPropertyType.EScriptPropertyType_FVector:
			return UnmanagedTypeMarshallingProcessor<FVector>.Read(buffer, ref offset);
		case EScriptPropertyType.EScriptPropertyType_FVector2D:
			return UnmanagedTypeMarshallingProcessor<FVector2D>.Read(buffer, ref offset);
		case EScriptPropertyType.EScriptPropertyType_FRotator:
			return UnmanagedTypeMarshallingProcessor<FRotator>.Read(buffer, ref offset);
		case EScriptPropertyType.EScriptPropertyType_FQuat:
			return UnmanagedTypeMarshallingProcessor<FQuat>.Read(buffer, ref offset);
		case EScriptPropertyType.EScriptPropertyType_FTransform:
			return UnmanagedTypeMarshallingProcessor<FTransform>.Read(buffer, ref offset);
		case EScriptPropertyType.EScriptPropertyType_FName:
			return GameScriptPropertyConverterUtils.ReadParameterBufferToFName(buffer, ref offset);
		case EScriptPropertyType.EScriptPropertyType_FKey:
			return new FKey(GameScriptPropertyConverterUtils.ReadParameterBufferToFName(buffer, ref offset));
		case EScriptPropertyType.EScriptPropertyType_UObject:
		{
			long num2 = UnmanagedTypeMarshallingProcessor<long>.Read(buffer, ref offset);
			if (num2 == 0L)
			{
				throw new NotImplementedException();
			}
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UObject>(new IntPtr(num2));
		}
		case EScriptPropertyType.EScriptPropertyType_Array:
			if (type == null)
			{
				throw new NotImplementedException();
			}
			return ListPropertyConverter.ReadParameterBuffer(propertyDefine, buffer, ref offset, type);
		case EScriptPropertyType.EScriptPropertyType_Set:
			if (type == null)
			{
				throw new NotImplementedException();
			}
			return HashSetPropertyConverter.ReadParameterBuffer(propertyDefine, buffer, ref offset, type);
		case EScriptPropertyType.EScriptPropertyType_Map:
			if (type == null)
			{
				throw new NotImplementedException();
			}
			return DictionaryPropertyConverter.ReadParameterBuffer(propertyDefine, buffer, ref offset, type);
		default:
			throw new NotImplementedException();
		}
	}

	// Token: 0x0600000E RID: 14 RVA: 0x00002930 File Offset: 0x00000B30
	public unsafe static void WriteParameterBuffer<[Nullable(2)] T>(ScriptPropertyDefine propertyDefine, in T value, [Nullable(0)] byte* buffer, ref int offset)
	{
		propertyDefine.Serialize(buffer, ref offset);
		if (propertyDefine.IsSpecialSerialize())
		{
			Type typeFromHandle = typeof(T);
			object obj = value;
			GameScriptPropertyConverterUtils.WriteParameterBufferFromObject(propertyDefine, obj, buffer, ref offset, typeFromHandle);
			return;
		}
		if (propertyDefine.IsString())
		{
			object obj = value;
			GameScriptPropertyConverterUtils.WriteParameterBufferFromObject(propertyDefine, obj, buffer, ref offset, null);
			return;
		}
		UnmanagedTypeMarshallingProcessor<T>.Write(buffer, ref offset, value);
	}

	// Token: 0x0600000F RID: 15 RVA: 0x00002998 File Offset: 0x00000B98
	[NullableContext(0)]
	public unsafe static void WriteParameterBuffer<[Nullable(2)] T>([Nullable(1)] in T value, byte* buffer, ref int offset)
	{
		UnmanagedTypeMarshallingProcessor<T>.Write(buffer, ref offset, value);
	}

	// Token: 0x06000010 RID: 16 RVA: 0x000029A4 File Offset: 0x00000BA4
	public unsafe static void WriteParameterBufferFromObject(ScriptPropertyDefine propertyDefine, in object value, [Nullable(0)] byte* buffer, ref int offset, [Nullable(2)] Type type)
	{
		switch (propertyDefine.Type)
		{
		case EScriptPropertyType.EScriptPropertyType_Boolean:
			GameScriptPropertyConverterUtils.WriteParameterBufferFromObject<bool>(buffer, ref offset, value);
			return;
		case EScriptPropertyType.EScriptPropertyType_Enum:
		case EScriptPropertyType.EScriptPropertyType_Int32:
			GameScriptPropertyConverterUtils.WriteParameterBufferFromObject<int>(buffer, ref offset, value);
			return;
		case EScriptPropertyType.EScriptPropertyType_Int8:
			GameScriptPropertyConverterUtils.WriteParameterBufferFromObject<sbyte>(buffer, ref offset, value);
			return;
		case EScriptPropertyType.EScriptPropertyType_UInt8:
			GameScriptPropertyConverterUtils.WriteParameterBufferFromObject<byte>(buffer, ref offset, value);
			return;
		case EScriptPropertyType.EScriptPropertyType_Int16:
			GameScriptPropertyConverterUtils.WriteParameterBufferFromObject<short>(buffer, ref offset, value);
			return;
		case EScriptPropertyType.EScriptPropertyType_UInt16:
			GameScriptPropertyConverterUtils.WriteParameterBufferFromObject<ushort>(buffer, ref offset, value);
			return;
		case EScriptPropertyType.EScriptPropertyType_UInt32:
			GameScriptPropertyConverterUtils.WriteParameterBufferFromObject<uint>(buffer, ref offset, value);
			return;
		case EScriptPropertyType.EScriptPropertyType_Int64:
		case EScriptPropertyType.EScriptPropertyType_UInt64:
			break;
		case EScriptPropertyType.EScriptPropertyType_Float:
			GameScriptPropertyConverterUtils.WriteParameterBufferFromObject<float>(buffer, ref offset, value);
			return;
		case EScriptPropertyType.EScriptPropertyType_Double:
			GameScriptPropertyConverterUtils.WriteParameterBufferFromObject<double>(buffer, ref offset, value);
			return;
		case EScriptPropertyType.EScriptPropertyType_String:
		{
			StringPropertyDefine stringPropertyDefine = (StringPropertyDefine)propertyDefine;
			if (stringPropertyDefine.IsPassByPointer)
			{
				long valueAddress = stringPropertyDefine.GetValueAddress();
				GameScriptPropertyConverterUtils.WriteParameterBuffer<long>(valueAddress, buffer, ref offset);
				return;
			}
			string text = (string)value;
			void* ptr;
			if (text == null)
			{
				ptr = null;
			}
			else
			{
				fixed (char* ptr2 = text.GetPinnableReference())
				{
					ptr = (void*)ptr2;
				}
			}
			void* source = ptr;
			uint num = (uint)(text.Length * 2);
			Unsafe.CopyBlock((void*)(buffer + offset), source, num);
			offset += (int)num;
			char* ptr2 = null;
			return;
		}
		case EScriptPropertyType.EScriptPropertyType_FArrayBuffer:
		{
			FArrayBuffer farrayBuffer = (FArrayBuffer)value;
			IntPtr intPtr = new IntPtr(farrayBuffer.Data);
			object obj = intPtr.ToInt64();
			GameScriptPropertyConverterUtils.WriteParameterBufferFromObject<long>(buffer, ref offset, obj);
			obj = farrayBuffer.Length;
			GameScriptPropertyConverterUtils.WriteParameterBufferFromObject<ulong>(buffer, ref offset, obj);
			return;
		}
		case EScriptPropertyType.EScriptPropertyType_FVector:
			GameScriptPropertyConverterUtils.WriteParameterBufferFromObject<FVector>(buffer, ref offset, value);
			return;
		case EScriptPropertyType.EScriptPropertyType_FVector2D:
			GameScriptPropertyConverterUtils.WriteParameterBufferFromObject<FVector2D>(buffer, ref offset, value);
			return;
		case EScriptPropertyType.EScriptPropertyType_FRotator:
			GameScriptPropertyConverterUtils.WriteParameterBufferFromObject<FRotator>(buffer, ref offset, value);
			return;
		case EScriptPropertyType.EScriptPropertyType_FQuat:
			GameScriptPropertyConverterUtils.WriteParameterBufferFromObject<FQuat>(buffer, ref offset, value);
			return;
		case EScriptPropertyType.EScriptPropertyType_FTransform:
			GameScriptPropertyConverterUtils.WriteParameterBufferFromObject<FTransform>(buffer, ref offset, value);
			return;
		case EScriptPropertyType.EScriptPropertyType_FName:
		{
			FName fname = (FName)value;
			GameScriptPropertyConverterUtils.WriteParameterBufferFromFName(buffer, ref offset, fname);
			return;
		}
		case EScriptPropertyType.EScriptPropertyType_FKey:
		{
			FName keyName = ((FKey)value).KeyName;
			GameScriptPropertyConverterUtils.WriteParameterBufferFromFName(buffer, ref offset, keyName);
			return;
		}
		case EScriptPropertyType.EScriptPropertyType_UObject:
		{
			UnrealObject unrealObject = (UnrealObject)value;
			object obj;
			if (unrealObject != null)
			{
				IntPtr nativePtr = unrealObject._NativePtr;
				obj = nativePtr.ToInt64();
				GameScriptPropertyConverterUtils.WriteParameterBufferFromObject<long>(buffer, ref offset, obj);
				return;
			}
			obj = 0;
			GameScriptPropertyConverterUtils.WriteParameterBufferFromObject<long>(buffer, ref offset, obj);
			break;
		}
		case EScriptPropertyType.EScriptPropertyType_Array:
			if (type == null)
			{
				throw new NotImplementedException();
			}
			ListPropertyConverter.WriteParameterBuffer(propertyDefine, value, buffer, ref offset, type);
			return;
		case EScriptPropertyType.EScriptPropertyType_Set:
			if (type == null)
			{
				throw new NotImplementedException();
			}
			HashSetPropertyConverter.WriteParameterBuffer(propertyDefine, value, buffer, ref offset, type);
			return;
		case EScriptPropertyType.EScriptPropertyType_Map:
			if (type == null)
			{
				throw new NotImplementedException();
			}
			DictionaryPropertyConverter.WriteParameterBuffer(propertyDefine, value, buffer, ref offset, type);
			return;
		default:
			return;
		}
	}

	// Token: 0x06000011 RID: 17 RVA: 0x00002BF4 File Offset: 0x00000DF4
	[NullableContext(0)]
	private unsafe static void WriteParameterBufferFromObject<[Nullable(2)] T>(byte* buffer, ref int offset, [Nullable(1)] in object value)
	{
		T t = (T)((object)value);
		UnmanagedTypeMarshallingProcessor<T>.Write(buffer, ref offset, t);
	}

	// Token: 0x06000012 RID: 18 RVA: 0x00002C14 File Offset: 0x00000E14
	[NullableContext(0)]
	public unsafe static void WriteParameterBufferFromFName(byte* buffer, ref int offset, in FName value)
	{
		uint comparisonIndex = value.ComparisonIndex;
		uint displayIndex = value.DisplayIndex;
		uint number = value.Number;
		UnmanagedTypeMarshallingProcessor<uint>.Write(buffer, ref offset, comparisonIndex);
		UnmanagedTypeMarshallingProcessor<uint>.Write(buffer, ref offset, displayIndex);
		UnmanagedTypeMarshallingProcessor<uint>.Write(buffer, ref offset, number);
	}

	// Token: 0x06000013 RID: 19 RVA: 0x00002C54 File Offset: 0x00000E54
	public static Type GetScriptPropertyType(ScriptPropertyDefine define)
	{
		switch (define.Type)
		{
		case EScriptPropertyType.EScriptPropertyType_Boolean:
			return typeof(bool);
		case EScriptPropertyType.EScriptPropertyType_Enum:
		case EScriptPropertyType.EScriptPropertyType_Int32:
			return typeof(int);
		case EScriptPropertyType.EScriptPropertyType_Int8:
			return typeof(sbyte);
		case EScriptPropertyType.EScriptPropertyType_UInt8:
			return typeof(byte);
		case EScriptPropertyType.EScriptPropertyType_Int16:
			return typeof(short);
		case EScriptPropertyType.EScriptPropertyType_UInt16:
			return typeof(ushort);
		case EScriptPropertyType.EScriptPropertyType_UInt32:
			return typeof(uint);
		case EScriptPropertyType.EScriptPropertyType_Int64:
			return typeof(long);
		case EScriptPropertyType.EScriptPropertyType_UInt64:
			return typeof(ulong);
		case EScriptPropertyType.EScriptPropertyType_Float:
			return typeof(float);
		case EScriptPropertyType.EScriptPropertyType_Double:
			return typeof(double);
		case EScriptPropertyType.EScriptPropertyType_String:
			return typeof(string);
		case EScriptPropertyType.EScriptPropertyType_FArrayBuffer:
			return typeof(FArrayBuffer);
		case EScriptPropertyType.EScriptPropertyType_FVector:
			return typeof(FVector);
		case EScriptPropertyType.EScriptPropertyType_FVector2D:
			return typeof(FVector2D);
		case EScriptPropertyType.EScriptPropertyType_FRotator:
			return typeof(FRotator);
		case EScriptPropertyType.EScriptPropertyType_FQuat:
			return typeof(FQuat);
		case EScriptPropertyType.EScriptPropertyType_FTransform:
			return typeof(FTransform);
		case EScriptPropertyType.EScriptPropertyType_FName:
			return typeof(FName);
		case EScriptPropertyType.EScriptPropertyType_FKey:
			return typeof(FKey);
		case EScriptPropertyType.EScriptPropertyType_UObject:
			return typeof(UnrealObject);
		case EScriptPropertyType.EScriptPropertyType_Array:
		{
			if (define.HeadElementProperty0 == null)
			{
				throw new Exception("GetScriptPropertyType List Failed");
			}
			Type scriptPropertyType = GameScriptPropertyConverterUtils.GetScriptPropertyType((define.HeadElementProperty0.IsContainerType() && define.ElementProperty0.Count > 0) ? define.ElementProperty0[0] : define.HeadElementProperty0);
			return typeof(List<>).MakeGenericType(new Type[]
			{
				scriptPropertyType
			});
		}
		case EScriptPropertyType.EScriptPropertyType_Set:
		{
			if (define.HeadElementProperty0 == null)
			{
				throw new Exception("GetScriptPropertyType HashSet Failed");
			}
			Type scriptPropertyType2 = GameScriptPropertyConverterUtils.GetScriptPropertyType((define.HeadElementProperty0.IsContainerType() && define.ElementProperty0.Count > 0) ? define.ElementProperty0[0] : define.HeadElementProperty0);
			return typeof(HashSet<>).MakeGenericType(new Type[]
			{
				scriptPropertyType2
			});
		}
		case EScriptPropertyType.EScriptPropertyType_Map:
		{
			if (define.HeadElementProperty0 == null || define.HeadElementProperty1 == null)
			{
				throw new Exception("GetScriptPropertyType Dictionary Failed");
			}
			ScriptPropertyDefine define2 = (define.HeadElementProperty0.IsContainerType() && define.ElementProperty0.Count > 0) ? define.ElementProperty0[0] : define.HeadElementProperty0;
			ScriptPropertyDefine define3 = (define.HeadElementProperty1.IsContainerType() && define.ElementProperty1.Count > 0) ? define.ElementProperty1[0] : define.HeadElementProperty1;
			Type scriptPropertyType3 = GameScriptPropertyConverterUtils.GetScriptPropertyType(define2);
			Type scriptPropertyType4 = GameScriptPropertyConverterUtils.GetScriptPropertyType(define3);
			return typeof(Dictionary<, >).MakeGenericType(new Type[]
			{
				scriptPropertyType3,
				scriptPropertyType4
			});
		}
		default:
			throw new NotImplementedException();
		}
	}

	// Token: 0x06000014 RID: 20 RVA: 0x00002F34 File Offset: 0x00001134
	public static int GetScriptPropertyTypeSize(ScriptPropertyDefine propertyDefine)
	{
		switch (propertyDefine.Type)
		{
		case EScriptPropertyType.EScriptPropertyType_Boolean:
			return 1;
		case EScriptPropertyType.EScriptPropertyType_Enum:
		case EScriptPropertyType.EScriptPropertyType_Int32:
			return 4;
		case EScriptPropertyType.EScriptPropertyType_Int8:
			return 1;
		case EScriptPropertyType.EScriptPropertyType_UInt8:
			return 1;
		case EScriptPropertyType.EScriptPropertyType_Int16:
			return 2;
		case EScriptPropertyType.EScriptPropertyType_UInt16:
			return 2;
		case EScriptPropertyType.EScriptPropertyType_UInt32:
			return 4;
		case EScriptPropertyType.EScriptPropertyType_Int64:
			return 8;
		case EScriptPropertyType.EScriptPropertyType_UInt64:
			return 8;
		case EScriptPropertyType.EScriptPropertyType_Float:
			return 4;
		case EScriptPropertyType.EScriptPropertyType_Double:
			return 8;
		case EScriptPropertyType.EScriptPropertyType_String:
		{
			StringPropertyDefine stringPropertyDefine = (StringPropertyDefine)propertyDefine;
			if (stringPropertyDefine.IsPassByPointer)
			{
				return 8;
			}
			return 2 * stringPropertyDefine.StringLength;
		}
		case EScriptPropertyType.EScriptPropertyType_FArrayBuffer:
			return sizeof(FArrayBuffer);
		case EScriptPropertyType.EScriptPropertyType_FVector:
			return sizeof(FVector);
		case EScriptPropertyType.EScriptPropertyType_FVector2D:
			return sizeof(FVector2D);
		case EScriptPropertyType.EScriptPropertyType_FRotator:
			return sizeof(FRotator);
		case EScriptPropertyType.EScriptPropertyType_FQuat:
			return sizeof(FQuat);
		case EScriptPropertyType.EScriptPropertyType_FTransform:
			return sizeof(FTransform);
		case EScriptPropertyType.EScriptPropertyType_FName:
		case EScriptPropertyType.EScriptPropertyType_FKey:
			return sizeof(FName);
		case EScriptPropertyType.EScriptPropertyType_UObject:
			return 8;
		case EScriptPropertyType.EScriptPropertyType_Array:
		case EScriptPropertyType.EScriptPropertyType_Set:
		{
			if (!propertyDefine.HeadElementProperty0.IsContainerType())
			{
				return propertyDefine.ElementCount * GameScriptPropertyConverterUtils.GetScriptPropertyTypeSize(propertyDefine.HeadElementProperty0);
			}
			int num = GameScriptPropertyConverterUtils.GetScriptPropertyTypeSize(propertyDefine.HeadElementProperty0);
			for (int i = 0; i < propertyDefine.ElementCount - 1; i++)
			{
				num += GameScriptPropertyConverterUtils.GetScriptPropertyTypeSize(propertyDefine.ElementProperty0[i]);
			}
			return num;
		}
		case EScriptPropertyType.EScriptPropertyType_Map:
		{
			int num2 = 0;
			bool flag = propertyDefine.HeadElementProperty0.IsContainerType();
			bool flag2 = propertyDefine.HeadElementProperty1.IsContainerType();
			for (int j = 0; j < propertyDefine.ElementCount; j++)
			{
				ScriptPropertyDefine propertyDefine2 = (flag && j > 0) ? propertyDefine.ElementProperty0[j - 1] : propertyDefine.HeadElementProperty0;
				ScriptPropertyDefine propertyDefine3 = (flag2 && j > 0) ? propertyDefine.ElementProperty1[j - 1] : propertyDefine.HeadElementProperty1;
				num2 += GameScriptPropertyConverterUtils.GetScriptPropertyTypeSize(propertyDefine2);
				num2 += GameScriptPropertyConverterUtils.GetScriptPropertyTypeSize(propertyDefine3);
			}
			return num2;
		}
		default:
			throw new NotImplementedException();
		}
	}

	// Token: 0x06000015 RID: 21 RVA: 0x00003107 File Offset: 0x00001307
	[NullableContext(2)]
	public static EScriptPropertyType GetScriptPropertyTypeEnum<T>()
	{
		return GameScriptPropertyConverterUtils.GetScriptPropertyTypeEnum(typeof(T));
	}

	// Token: 0x06000016 RID: 22 RVA: 0x00003118 File Offset: 0x00001318
	public static EScriptPropertyType GetScriptPropertyTypeEnum(Type type)
	{
		if (type.IsEnum)
		{
			return EScriptPropertyType.EScriptPropertyType_Enum;
		}
		if (type == typeof(bool))
		{
			return EScriptPropertyType.EScriptPropertyType_Boolean;
		}
		if (type == typeof(sbyte))
		{
			return EScriptPropertyType.EScriptPropertyType_Int8;
		}
		if (type == typeof(byte))
		{
			return EScriptPropertyType.EScriptPropertyType_UInt8;
		}
		if (type == typeof(short))
		{
			return EScriptPropertyType.EScriptPropertyType_Int16;
		}
		if (type == typeof(ushort))
		{
			return EScriptPropertyType.EScriptPropertyType_UInt16;
		}
		if (type == typeof(int))
		{
			return EScriptPropertyType.EScriptPropertyType_Int32;
		}
		if (type == typeof(uint))
		{
			return EScriptPropertyType.EScriptPropertyType_UInt32;
		}
		if (type == typeof(long))
		{
			return EScriptPropertyType.EScriptPropertyType_Int64;
		}
		if (type == typeof(ulong))
		{
			return EScriptPropertyType.EScriptPropertyType_UInt64;
		}
		if (type == typeof(float))
		{
			return EScriptPropertyType.EScriptPropertyType_Float;
		}
		if (type == typeof(double))
		{
			return EScriptPropertyType.EScriptPropertyType_Double;
		}
		if (type == typeof(FVector))
		{
			return EScriptPropertyType.EScriptPropertyType_FVector;
		}
		if (type == typeof(FVector2D))
		{
			return EScriptPropertyType.EScriptPropertyType_FVector2D;
		}
		if (type == typeof(FRotator))
		{
			return EScriptPropertyType.EScriptPropertyType_FRotator;
		}
		if (type == typeof(FQuat))
		{
			return EScriptPropertyType.EScriptPropertyType_FQuat;
		}
		if (type == typeof(FTransform))
		{
			return EScriptPropertyType.EScriptPropertyType_FTransform;
		}
		if (type == typeof(FName))
		{
			return EScriptPropertyType.EScriptPropertyType_FName;
		}
		if (type == typeof(FKey))
		{
			return EScriptPropertyType.EScriptPropertyType_FKey;
		}
		if (type == typeof(FArrayBuffer))
		{
			return EScriptPropertyType.EScriptPropertyType_FArrayBuffer;
		}
		if (type.IsSubclassOf(typeof(UnrealObject)))
		{
			return EScriptPropertyType.EScriptPropertyType_UObject;
		}
		if (type == typeof(string))
		{
			return EScriptPropertyType.EScriptPropertyType_String;
		}
		if (type.IsGenericType)
		{
			if (type.GetGenericTypeDefinition() == typeof(List<>))
			{
				return EScriptPropertyType.EScriptPropertyType_Array;
			}
			if (type.GetGenericTypeDefinition() == typeof(HashSet<>))
			{
				return EScriptPropertyType.EScriptPropertyType_Set;
			}
			if (type.GetGenericTypeDefinition() == typeof(Dictionary<, >))
			{
				return EScriptPropertyType.EScriptPropertyType_Map;
			}
		}
		return EScriptPropertyType.EScriptPropertyType_None;
	}

	// Token: 0x06000017 RID: 23 RVA: 0x00003339 File Offset: 0x00001539
	public static ScriptPropertyDefine GetEventParameterPropertyDefine<[Nullable(2)] T>(T value)
	{
		return GameScriptPropertyConverterUtils.GetEventParameterPropertyDefine(typeof(T), value);
	}

	// Token: 0x06000018 RID: 24 RVA: 0x00003350 File Offset: 0x00001550
	private static ScriptPropertyDefine GetEventParameterPropertyDefine(Type type, [Nullable(2)] object value)
	{
		ScriptPropertyDefine scriptPropertyDefine;
		if (GameScriptPropertyConverterUtils.GetScriptPropertyTypeEnum(type) == EScriptPropertyType.EScriptPropertyType_String)
		{
			string value2 = (string)value;
			scriptPropertyDefine = new StringPropertyDefine(true, value2);
		}
		else
		{
			scriptPropertyDefine = new ScriptPropertyDefine();
		}
		scriptPropertyDefine.Type = GameScriptPropertyConverterUtils.GetScriptPropertyTypeEnum(type);
		if (value == null)
		{
			return scriptPropertyDefine;
		}
		if (scriptPropertyDefine.Type == EScriptPropertyType.EScriptPropertyType_Array)
		{
			Type type2 = type.GetGenericArguments()[0];
			IList list = (IList)value;
			scriptPropertyDefine.ElementCount = list.Count;
			scriptPropertyDefine.HeadElementProperty0 = GameScriptPropertyConverterUtils.GetEventParameterPropertyDefine(type2, (list.Count > 0) ? list[0] : null);
			if (scriptPropertyDefine.HeadElementProperty0.IsContainerType())
			{
				scriptPropertyDefine.ElementProperty0.Clear();
				for (int i = 1; i < list.Count; i++)
				{
					scriptPropertyDefine.ElementProperty0.Add(GameScriptPropertyConverterUtils.GetEventParameterPropertyDefine(type2, list[i]));
				}
			}
		}
		else
		{
			if (scriptPropertyDefine.Type == EScriptPropertyType.EScriptPropertyType_Set)
			{
				Type type3 = type.GetGenericArguments()[0];
				IEnumerator enumerator = ((IEnumerable)value).GetEnumerator();
				PropertyInfo property = value.GetType().GetProperty("Count");
				if (property != null)
				{
					object value3 = property.GetValue(value);
					if (value3 != null)
					{
						scriptPropertyDefine.ElementCount = (int)value3;
					}
				}
				try
				{
					enumerator.MoveNext();
					scriptPropertyDefine.HeadElementProperty0 = GameScriptPropertyConverterUtils.GetEventParameterPropertyDefine(type3, enumerator.Current);
					if (scriptPropertyDefine.HeadElementProperty0.IsContainerType())
					{
						scriptPropertyDefine.ElementProperty0.Clear();
						while (enumerator.MoveNext())
						{
							object value4 = enumerator.Current;
							scriptPropertyDefine.ElementProperty0.Add(GameScriptPropertyConverterUtils.GetEventParameterPropertyDefine(type3, value4));
						}
					}
					return scriptPropertyDefine;
				}
				finally
				{
					IDisposable disposable = enumerator as IDisposable;
					if (disposable != null)
					{
						disposable.Dispose();
					}
				}
			}
			if (scriptPropertyDefine.Type == EScriptPropertyType.EScriptPropertyType_Map)
			{
				Type type4 = type.GetGenericArguments()[0];
				Type type5 = type.GetGenericArguments()[1];
				IDictionary dictionary = (IDictionary)value;
				scriptPropertyDefine.ElementCount = dictionary.Count;
				using (IDictionaryEnumerator enumerator2 = dictionary.GetEnumerator())
				{
					enumerator2.MoveNext();
					scriptPropertyDefine.HeadElementProperty0 = GameScriptPropertyConverterUtils.GetEventParameterPropertyDefine(type4, enumerator2.Key);
					scriptPropertyDefine.HeadElementProperty1 = GameScriptPropertyConverterUtils.GetEventParameterPropertyDefine(type5, enumerator2.Value);
					bool flag = scriptPropertyDefine.HeadElementProperty0.IsContainerType();
					bool flag2 = scriptPropertyDefine.HeadElementProperty1.IsContainerType();
					if (flag || flag2)
					{
						scriptPropertyDefine.ElementProperty0.Clear();
						scriptPropertyDefine.ElementProperty1.Clear();
						while (enumerator2.MoveNext())
						{
							if (flag)
							{
								scriptPropertyDefine.ElementProperty0.Add(GameScriptPropertyConverterUtils.GetEventParameterPropertyDefine(type4, enumerator2.Key));
							}
							if (flag2)
							{
								scriptPropertyDefine.ElementProperty1.Add(GameScriptPropertyConverterUtils.GetEventParameterPropertyDefine(type5, enumerator2.Value));
							}
						}
					}
				}
			}
		}
		return scriptPropertyDefine;
	}
}
