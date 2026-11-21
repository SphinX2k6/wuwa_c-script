using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using System.Reflection.Emit;

namespace System.Text.Json.Serialization.Metadata
{
	// Token: 0x020000EB RID: 235
	internal sealed class ReflectionEmitMemberAccessor : MemberAccessor
	{
		// Token: 0x06000C8D RID: 3213 RVA: 0x00031A86 File Offset: 0x0002FC86
		[RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
		[RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
		public ReflectionEmitMemberAccessor()
		{
		}

		// Token: 0x06000C8E RID: 3214 RVA: 0x00031A90 File Offset: 0x0002FC90
		[UnconditionalSuppressMessage("AOT", "IL3050:Calling members annotated with 'RequiresDynamicCodeAttribute' may break functionality when AOT compiling.", Justification = "The constructor has been marked RequiresDynamicCode")]
		public override Func<object> CreateParameterlessConstructor(Type type, ConstructorInfo constructorInfo)
		{
			if (type.IsAbstract)
			{
				return null;
			}
			if (constructorInfo == null && !type.IsValueType)
			{
				return null;
			}
			DynamicMethod dynamicMethod = new DynamicMethod(ConstructorInfo.ConstructorName, JsonTypeInfo.ObjectType, Type.EmptyTypes, typeof(ReflectionEmitMemberAccessor).Module, true);
			ILGenerator ilgenerator = dynamicMethod.GetILGenerator();
			if (constructorInfo == null)
			{
				LocalBuilder local = ilgenerator.DeclareLocal(type);
				ilgenerator.Emit(OpCodes.Ldloca_S, local);
				ilgenerator.Emit(OpCodes.Initobj, type);
				ilgenerator.Emit(OpCodes.Ldloc, local);
				ilgenerator.Emit(OpCodes.Box, type);
			}
			else
			{
				ilgenerator.Emit(OpCodes.Newobj, constructorInfo);
				if (type.IsValueType)
				{
					ilgenerator.Emit(OpCodes.Box, type);
				}
			}
			ilgenerator.Emit(OpCodes.Ret);
			return ReflectionEmitMemberAccessor.CreateDelegate<Func<object>>(dynamicMethod);
		}

		// Token: 0x06000C8F RID: 3215 RVA: 0x00031B4C File Offset: 0x0002FD4C
		public override Func<object[], T> CreateParameterizedConstructor<T>(ConstructorInfo constructor)
		{
			return ReflectionEmitMemberAccessor.CreateDelegate<Func<object[], T>>(ReflectionEmitMemberAccessor.CreateParameterizedConstructor(constructor));
		}

		// Token: 0x06000C90 RID: 3216 RVA: 0x00031B5C File Offset: 0x0002FD5C
		[UnconditionalSuppressMessage("AOT", "IL3050:Calling members annotated with 'RequiresDynamicCodeAttribute' may break functionality when AOT compiling.", Justification = "The constructor has been marked RequiresDynamicCode")]
		private static DynamicMethod CreateParameterizedConstructor(ConstructorInfo constructor)
		{
			Type declaringType = constructor.DeclaringType;
			ParameterInfo[] parameters = constructor.GetParameters();
			int num = parameters.Length;
			DynamicMethod dynamicMethod = new DynamicMethod(ConstructorInfo.ConstructorName, declaringType, new Type[]
			{
				typeof(object[])
			}, typeof(ReflectionEmitMemberAccessor).Module, true);
			ILGenerator ilgenerator = dynamicMethod.GetILGenerator();
			for (int i = 0; i < num; i++)
			{
				Type parameterType = parameters[i].ParameterType;
				ilgenerator.Emit(OpCodes.Ldarg_0);
				ilgenerator.Emit(OpCodes.Ldc_I4, i);
				ilgenerator.Emit(OpCodes.Ldelem_Ref);
				ilgenerator.Emit(OpCodes.Unbox_Any, parameterType);
			}
			ilgenerator.Emit(OpCodes.Newobj, constructor);
			ilgenerator.Emit(OpCodes.Ret);
			return dynamicMethod;
		}

		// Token: 0x06000C91 RID: 3217 RVA: 0x00031C1B File Offset: 0x0002FE1B
		public override JsonTypeInfo.ParameterizedConstructorDelegate<T, TArg0, TArg1, TArg2, TArg3> CreateParameterizedConstructor<T, TArg0, TArg1, TArg2, TArg3>(ConstructorInfo constructor)
		{
			return ReflectionEmitMemberAccessor.CreateDelegate<JsonTypeInfo.ParameterizedConstructorDelegate<T, TArg0, TArg1, TArg2, TArg3>>(ReflectionEmitMemberAccessor.CreateParameterizedConstructor(constructor, typeof(TArg0), typeof(TArg1), typeof(TArg2), typeof(TArg3)));
		}

		// Token: 0x06000C92 RID: 3218 RVA: 0x00031C50 File Offset: 0x0002FE50
		[UnconditionalSuppressMessage("AOT", "IL3050:Calling members annotated with 'RequiresDynamicCodeAttribute' may break functionality when AOT compiling.", Justification = "The constructor has been marked RequiresDynamicCode")]
		private static DynamicMethod CreateParameterizedConstructor(ConstructorInfo constructor, Type parameterType1, Type parameterType2, Type parameterType3, Type parameterType4)
		{
			Type declaringType = constructor.DeclaringType;
			int num = constructor.GetParameters().Length;
			DynamicMethod dynamicMethod = new DynamicMethod(ConstructorInfo.ConstructorName, declaringType, new Type[]
			{
				parameterType1,
				parameterType2,
				parameterType3,
				parameterType4
			}, typeof(ReflectionEmitMemberAccessor).Module, true);
			ILGenerator ilgenerator = dynamicMethod.GetILGenerator();
			for (int i = 0; i < num; i++)
			{
				ILGenerator ilgenerator2 = ilgenerator;
				OpCode opcode;
				switch (i)
				{
				case 0:
					opcode = OpCodes.Ldarg_0;
					break;
				case 1:
					opcode = OpCodes.Ldarg_1;
					break;
				case 2:
					opcode = OpCodes.Ldarg_2;
					break;
				case 3:
					opcode = OpCodes.Ldarg_3;
					break;
				default:
					throw new InvalidOperationException();
				}
				ilgenerator2.Emit(opcode);
			}
			ilgenerator.Emit(OpCodes.Newobj, constructor);
			ilgenerator.Emit(OpCodes.Ret);
			return dynamicMethod;
		}

		// Token: 0x06000C93 RID: 3219 RVA: 0x00031D1E File Offset: 0x0002FF1E
		public override Action<TCollection, object> CreateAddMethodDelegate<[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicMethods)] TCollection>()
		{
			return ReflectionEmitMemberAccessor.CreateDelegate<Action<TCollection, object>>(ReflectionEmitMemberAccessor.CreateAddMethodDelegate(typeof(TCollection)));
		}

		// Token: 0x06000C94 RID: 3220 RVA: 0x00031D34 File Offset: 0x0002FF34
		[UnconditionalSuppressMessage("AOT", "IL3050:Calling members annotated with 'RequiresDynamicCodeAttribute' may break functionality when AOT compiling.", Justification = "The constructor has been marked RequiresDynamicCode")]
		private static DynamicMethod CreateAddMethodDelegate([DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicMethods)] Type collectionType)
		{
			MethodInfo methodInfo = collectionType.GetMethod("Push") ?? collectionType.GetMethod("Enqueue");
			DynamicMethod dynamicMethod = new DynamicMethod(methodInfo.Name, typeof(void), new Type[]
			{
				collectionType,
				JsonTypeInfo.ObjectType
			}, typeof(ReflectionEmitMemberAccessor).Module, true);
			ILGenerator ilgenerator = dynamicMethod.GetILGenerator();
			ilgenerator.Emit(OpCodes.Ldarg_0);
			ilgenerator.Emit(OpCodes.Ldarg_1);
			ilgenerator.Emit(OpCodes.Callvirt, methodInfo);
			ilgenerator.Emit(OpCodes.Ret);
			return dynamicMethod;
		}

		// Token: 0x06000C95 RID: 3221 RVA: 0x00031DC5 File Offset: 0x0002FFC5
		public override Func<IEnumerable<TElement>, TCollection> CreateImmutableEnumerableCreateRangeDelegate<TCollection, TElement>()
		{
			return ReflectionEmitMemberAccessor.CreateDelegate<Func<IEnumerable<TElement>, TCollection>>(ReflectionEmitMemberAccessor.CreateImmutableEnumerableCreateRangeDelegate(typeof(TCollection), typeof(TElement), typeof(IEnumerable<TElement>)));
		}

		// Token: 0x06000C96 RID: 3222 RVA: 0x00031DF0 File Offset: 0x0002FFF0
		[UnconditionalSuppressMessage("AOT", "IL3050:Calling members annotated with 'RequiresDynamicCodeAttribute' may break functionality when AOT compiling.", Justification = "The constructor has been marked RequiresDynamicCode")]
		[UnconditionalSuppressMessage("Trimming", "IL2026:Members annotated with 'RequiresUnreferencedCodeAttribute' require dynamic access otherwise can break functionality when trimming application code", Justification = "The constructor has been marked RequiresUnreferencedCode")]
		private static DynamicMethod CreateImmutableEnumerableCreateRangeDelegate(Type collectionType, Type elementType, Type enumerableType)
		{
			MethodInfo immutableEnumerableCreateRangeMethod = collectionType.GetImmutableEnumerableCreateRangeMethod(elementType);
			DynamicMethod dynamicMethod = new DynamicMethod(immutableEnumerableCreateRangeMethod.Name, collectionType, new Type[]
			{
				enumerableType
			}, typeof(ReflectionEmitMemberAccessor).Module, true);
			ILGenerator ilgenerator = dynamicMethod.GetILGenerator();
			ilgenerator.Emit(OpCodes.Ldarg_0);
			ilgenerator.Emit(OpCodes.Call, immutableEnumerableCreateRangeMethod);
			ilgenerator.Emit(OpCodes.Ret);
			return dynamicMethod;
		}

		// Token: 0x06000C97 RID: 3223 RVA: 0x00031E52 File Offset: 0x00030052
		public override Func<IEnumerable<KeyValuePair<TKey, TValue>>, TCollection> CreateImmutableDictionaryCreateRangeDelegate<TCollection, TKey, TValue>()
		{
			return ReflectionEmitMemberAccessor.CreateDelegate<Func<IEnumerable<KeyValuePair<TKey, TValue>>, TCollection>>(ReflectionEmitMemberAccessor.CreateImmutableDictionaryCreateRangeDelegate(typeof(TCollection), typeof(TKey), typeof(TValue), typeof(IEnumerable<KeyValuePair<TKey, TValue>>)));
		}

		// Token: 0x06000C98 RID: 3224 RVA: 0x00031E88 File Offset: 0x00030088
		[UnconditionalSuppressMessage("AOT", "IL3050:Calling members annotated with 'RequiresDynamicCodeAttribute' may break functionality when AOT compiling.", Justification = "The constructor has been marked RequiresDynamicCode")]
		[UnconditionalSuppressMessage("Trimming", "IL2026:Members annotated with 'RequiresUnreferencedCodeAttribute' require dynamic access otherwise can break functionality when trimming application code", Justification = "The constructor has been marked RequiresUnreferencedCode")]
		private static DynamicMethod CreateImmutableDictionaryCreateRangeDelegate(Type collectionType, Type keyType, Type valueType, Type enumerableType)
		{
			MethodInfo immutableDictionaryCreateRangeMethod = collectionType.GetImmutableDictionaryCreateRangeMethod(keyType, valueType);
			DynamicMethod dynamicMethod = new DynamicMethod(immutableDictionaryCreateRangeMethod.Name, collectionType, new Type[]
			{
				enumerableType
			}, typeof(ReflectionEmitMemberAccessor).Module, true);
			ILGenerator ilgenerator = dynamicMethod.GetILGenerator();
			ilgenerator.Emit(OpCodes.Ldarg_0);
			ilgenerator.Emit(OpCodes.Call, immutableDictionaryCreateRangeMethod);
			ilgenerator.Emit(OpCodes.Ret);
			return dynamicMethod;
		}

		// Token: 0x06000C99 RID: 3225 RVA: 0x00031EEB File Offset: 0x000300EB
		public override Func<object, TProperty> CreatePropertyGetter<TProperty>(PropertyInfo propertyInfo)
		{
			return ReflectionEmitMemberAccessor.CreateDelegate<Func<object, TProperty>>(ReflectionEmitMemberAccessor.CreatePropertyGetter(propertyInfo, typeof(TProperty)));
		}

		// Token: 0x06000C9A RID: 3226 RVA: 0x00031F04 File Offset: 0x00030104
		private static DynamicMethod CreatePropertyGetter(PropertyInfo propertyInfo, Type runtimePropertyType)
		{
			MethodInfo getMethod = propertyInfo.GetMethod;
			Type declaringType = propertyInfo.DeclaringType;
			Type propertyType = propertyInfo.PropertyType;
			DynamicMethod dynamicMethod = ReflectionEmitMemberAccessor.CreateGetterMethod(propertyInfo.Name, runtimePropertyType);
			ILGenerator ilgenerator = dynamicMethod.GetILGenerator();
			ilgenerator.Emit(OpCodes.Ldarg_0);
			if (declaringType.IsValueType)
			{
				ilgenerator.Emit(OpCodes.Unbox, declaringType);
				ilgenerator.Emit(OpCodes.Call, getMethod);
			}
			else
			{
				ilgenerator.Emit(OpCodes.Castclass, declaringType);
				ilgenerator.Emit(OpCodes.Callvirt, getMethod);
			}
			if (propertyType != runtimePropertyType && propertyType.IsValueType)
			{
				ilgenerator.Emit(OpCodes.Box, propertyType);
			}
			ilgenerator.Emit(OpCodes.Ret);
			return dynamicMethod;
		}

		// Token: 0x06000C9B RID: 3227 RVA: 0x00031FA6 File Offset: 0x000301A6
		public override Action<object, TProperty> CreatePropertySetter<TProperty>(PropertyInfo propertyInfo)
		{
			return ReflectionEmitMemberAccessor.CreateDelegate<Action<object, TProperty>>(ReflectionEmitMemberAccessor.CreatePropertySetter(propertyInfo, typeof(TProperty)));
		}

		// Token: 0x06000C9C RID: 3228 RVA: 0x00031FC0 File Offset: 0x000301C0
		private static DynamicMethod CreatePropertySetter(PropertyInfo propertyInfo, Type runtimePropertyType)
		{
			MethodInfo setMethod = propertyInfo.SetMethod;
			Type declaringType = propertyInfo.DeclaringType;
			Type propertyType = propertyInfo.PropertyType;
			DynamicMethod dynamicMethod = ReflectionEmitMemberAccessor.CreateSetterMethod(propertyInfo.Name, runtimePropertyType);
			ILGenerator ilgenerator = dynamicMethod.GetILGenerator();
			ilgenerator.Emit(OpCodes.Ldarg_0);
			ilgenerator.Emit(declaringType.IsValueType ? OpCodes.Unbox : OpCodes.Castclass, declaringType);
			ilgenerator.Emit(OpCodes.Ldarg_1);
			if (propertyType != runtimePropertyType && propertyType.IsValueType)
			{
				ilgenerator.Emit(OpCodes.Unbox_Any, propertyType);
			}
			ilgenerator.Emit(declaringType.IsValueType ? OpCodes.Call : OpCodes.Callvirt, setMethod);
			ilgenerator.Emit(OpCodes.Ret);
			return dynamicMethod;
		}

		// Token: 0x06000C9D RID: 3229 RVA: 0x00032069 File Offset: 0x00030269
		public override Func<object, TProperty> CreateFieldGetter<TProperty>(FieldInfo fieldInfo)
		{
			return ReflectionEmitMemberAccessor.CreateDelegate<Func<object, TProperty>>(ReflectionEmitMemberAccessor.CreateFieldGetter(fieldInfo, typeof(TProperty)));
		}

		// Token: 0x06000C9E RID: 3230 RVA: 0x00032080 File Offset: 0x00030280
		private static DynamicMethod CreateFieldGetter(FieldInfo fieldInfo, Type runtimeFieldType)
		{
			Type declaringType = fieldInfo.DeclaringType;
			Type fieldType = fieldInfo.FieldType;
			DynamicMethod dynamicMethod = ReflectionEmitMemberAccessor.CreateGetterMethod(fieldInfo.Name, runtimeFieldType);
			ILGenerator ilgenerator = dynamicMethod.GetILGenerator();
			ilgenerator.Emit(OpCodes.Ldarg_0);
			ilgenerator.Emit(declaringType.IsValueType ? OpCodes.Unbox : OpCodes.Castclass, declaringType);
			ilgenerator.Emit(OpCodes.Ldfld, fieldInfo);
			if (fieldType.IsValueType && fieldType != runtimeFieldType)
			{
				ilgenerator.Emit(OpCodes.Box, fieldType);
			}
			ilgenerator.Emit(OpCodes.Ret);
			return dynamicMethod;
		}

		// Token: 0x06000C9F RID: 3231 RVA: 0x00032108 File Offset: 0x00030308
		public override Action<object, TProperty> CreateFieldSetter<TProperty>(FieldInfo fieldInfo)
		{
			return ReflectionEmitMemberAccessor.CreateDelegate<Action<object, TProperty>>(ReflectionEmitMemberAccessor.CreateFieldSetter(fieldInfo, typeof(TProperty)));
		}

		// Token: 0x06000CA0 RID: 3232 RVA: 0x00032120 File Offset: 0x00030320
		private static DynamicMethod CreateFieldSetter(FieldInfo fieldInfo, Type runtimeFieldType)
		{
			Type declaringType = fieldInfo.DeclaringType;
			Type fieldType = fieldInfo.FieldType;
			DynamicMethod dynamicMethod = ReflectionEmitMemberAccessor.CreateSetterMethod(fieldInfo.Name, runtimeFieldType);
			ILGenerator ilgenerator = dynamicMethod.GetILGenerator();
			ilgenerator.Emit(OpCodes.Ldarg_0);
			ilgenerator.Emit(declaringType.IsValueType ? OpCodes.Unbox : OpCodes.Castclass, declaringType);
			ilgenerator.Emit(OpCodes.Ldarg_1);
			if (fieldType != runtimeFieldType && fieldType.IsValueType)
			{
				ilgenerator.Emit(OpCodes.Unbox_Any, fieldType);
			}
			ilgenerator.Emit(OpCodes.Stfld, fieldInfo);
			ilgenerator.Emit(OpCodes.Ret);
			return dynamicMethod;
		}

		// Token: 0x06000CA1 RID: 3233 RVA: 0x000321B3 File Offset: 0x000303B3
		[UnconditionalSuppressMessage("AOT", "IL3050:Calling members annotated with 'RequiresDynamicCodeAttribute' may break functionality when AOT compiling.", Justification = "The constructor has been marked RequiresDynamicCode")]
		private static DynamicMethod CreateGetterMethod(string memberName, Type memberType)
		{
			return new DynamicMethod(memberName + "Getter", memberType, new Type[]
			{
				JsonTypeInfo.ObjectType
			}, typeof(ReflectionEmitMemberAccessor).Module, true);
		}

		// Token: 0x06000CA2 RID: 3234 RVA: 0x000321E4 File Offset: 0x000303E4
		[UnconditionalSuppressMessage("AOT", "IL3050:Calling members annotated with 'RequiresDynamicCodeAttribute' may break functionality when AOT compiling.", Justification = "The constructor has been marked RequiresDynamicCode")]
		private static DynamicMethod CreateSetterMethod(string memberName, Type memberType)
		{
			return new DynamicMethod(memberName + "Setter", typeof(void), new Type[]
			{
				JsonTypeInfo.ObjectType,
				memberType
			}, typeof(ReflectionEmitMemberAccessor).Module, true);
		}

		// Token: 0x06000CA3 RID: 3235 RVA: 0x00032222 File Offset: 0x00030422
		[return: NotNullIfNotNull("method")]
		private static T CreateDelegate<T>(DynamicMethod method) where T : Delegate
		{
			return (T)((object)((method != null) ? method.CreateDelegate(typeof(T)) : null));
		}
	}
}
