using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;

namespace System.Text.Json.Serialization.Metadata
{
	// Token: 0x020000EC RID: 236
	internal sealed class ReflectionMemberAccessor : MemberAccessor
	{
		// Token: 0x06000CA4 RID: 3236 RVA: 0x00031A86 File Offset: 0x0002FC86
		[RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
		[RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
		public ReflectionMemberAccessor()
		{
		}

		// Token: 0x06000CA5 RID: 3237 RVA: 0x00032240 File Offset: 0x00030440
		[UnconditionalSuppressMessage("Trimming", "IL2067:Target parameter argument does not satisfy 'DynamicallyAccessedMembersAttribute' in call to target method. The parameter of method does not have matching annotations.", Justification = "The constructor has been marked RequiresUnreferencedCode")]
		public override Func<object> CreateParameterlessConstructor(Type type, ConstructorInfo ctorInfo)
		{
			if (type.IsAbstract)
			{
				return null;
			}
			if (ctorInfo != null)
			{
				return () => ctorInfo.Invoke(null);
			}
			if (!type.IsValueType)
			{
				return null;
			}
			return () => Activator.CreateInstance(type, false);
		}

		// Token: 0x06000CA6 RID: 3238 RVA: 0x000322A0 File Offset: 0x000304A0
		public override Func<object[], T> CreateParameterizedConstructor<T>(ConstructorInfo constructor)
		{
			int parameterCount = constructor.GetParameters().Length;
			return delegate(object[] arguments)
			{
				object[] array = new object[parameterCount];
				for (int i = 0; i < parameterCount; i++)
				{
					array[i] = arguments[i];
				}
				T result;
				try
				{
					result = (T)((object)constructor.Invoke(array));
				}
				catch (TargetInvocationException ex)
				{
					throw ex.InnerException ?? ex;
				}
				return result;
			};
		}

		// Token: 0x06000CA7 RID: 3239 RVA: 0x000322CC File Offset: 0x000304CC
		public override JsonTypeInfo.ParameterizedConstructorDelegate<T, TArg0, TArg1, TArg2, TArg3> CreateParameterizedConstructor<T, TArg0, TArg1, TArg2, TArg3>(ConstructorInfo constructor)
		{
			int parameterCount = constructor.GetParameters().Length;
			return delegate(TArg0 arg0, TArg1 arg1, TArg2 arg2, TArg3 arg3)
			{
				object[] array = new object[parameterCount];
				for (int i = 0; i < parameterCount; i++)
				{
					switch (i)
					{
					case 0:
						array[0] = arg0;
						break;
					case 1:
						array[1] = arg1;
						break;
					case 2:
						array[2] = arg2;
						break;
					case 3:
						array[3] = arg3;
						break;
					default:
						throw new InvalidOperationException();
					}
				}
				return (T)((object)constructor.Invoke(array));
			};
		}

		// Token: 0x06000CA8 RID: 3240 RVA: 0x000322F8 File Offset: 0x000304F8
		public override Action<TCollection, object> CreateAddMethodDelegate<[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicMethods)] TCollection>()
		{
			Type typeFromHandle = typeof(TCollection);
			Type objectType = JsonTypeInfo.ObjectType;
			MethodInfo addMethod = typeFromHandle.GetMethod("Push") ?? typeFromHandle.GetMethod("Enqueue");
			return delegate(TCollection collection, object element)
			{
				addMethod.Invoke(collection, new object[]
				{
					element
				});
			};
		}

		// Token: 0x06000CA9 RID: 3241 RVA: 0x00032346 File Offset: 0x00030546
		[UnconditionalSuppressMessage("Trimming", "IL2026:Members annotated with 'RequiresUnreferencedCodeAttribute' require dynamic access otherwise can break functionality when trimming application code", Justification = "The constructor has been marked RequiresUnreferencedCode")]
		[UnconditionalSuppressMessage("AOT", "IL3050:Calling members annotated with 'RequiresDynamicCodeAttribute' may break functionality when AOT compiling.", Justification = "The constructor has been marked RequiresDynamicCode")]
		public override Func<IEnumerable<TElement>, TCollection> CreateImmutableEnumerableCreateRangeDelegate<TCollection, TElement>()
		{
			return (Func<IEnumerable<TElement>, TCollection>)typeof(TCollection).GetImmutableEnumerableCreateRangeMethod(typeof(TElement)).CreateDelegate(typeof(Func<IEnumerable<TElement>, TCollection>));
		}

		// Token: 0x06000CAA RID: 3242 RVA: 0x00032375 File Offset: 0x00030575
		[UnconditionalSuppressMessage("Trimming", "IL2026:Members annotated with 'RequiresUnreferencedCodeAttribute' require dynamic access otherwise can break functionality when trimming application code", Justification = "The constructor has been marked RequiresUnreferencedCode")]
		[UnconditionalSuppressMessage("AOT", "IL3050:Calling members annotated with 'RequiresDynamicCodeAttribute' may break functionality when AOT compiling.", Justification = "The constructor has been marked RequiresDynamicCode")]
		public override Func<IEnumerable<KeyValuePair<TKey, TValue>>, TCollection> CreateImmutableDictionaryCreateRangeDelegate<TCollection, TKey, TValue>()
		{
			return (Func<IEnumerable<KeyValuePair<TKey, TValue>>, TCollection>)typeof(TCollection).GetImmutableDictionaryCreateRangeMethod(typeof(TKey), typeof(TValue)).CreateDelegate(typeof(Func<IEnumerable<KeyValuePair<TKey, TValue>>, TCollection>));
		}

		// Token: 0x06000CAB RID: 3243 RVA: 0x000323AE File Offset: 0x000305AE
		public override Func<object, TProperty> CreatePropertyGetter<TProperty>(PropertyInfo propertyInfo)
		{
			MethodInfo getMethodInfo = propertyInfo.GetMethod;
			return (object obj) => (TProperty)((object)getMethodInfo.Invoke(obj, null));
		}

		// Token: 0x06000CAC RID: 3244 RVA: 0x000323CC File Offset: 0x000305CC
		public override Action<object, TProperty> CreatePropertySetter<TProperty>(PropertyInfo propertyInfo)
		{
			MethodInfo setMethodInfo = propertyInfo.SetMethod;
			return delegate(object obj, TProperty value)
			{
				setMethodInfo.Invoke(obj, new object[]
				{
					value
				});
			};
		}

		// Token: 0x06000CAD RID: 3245 RVA: 0x000323EA File Offset: 0x000305EA
		public override Func<object, TProperty> CreateFieldGetter<TProperty>(FieldInfo fieldInfo)
		{
			return (object obj) => (TProperty)((object)fieldInfo.GetValue(obj));
		}

		// Token: 0x06000CAE RID: 3246 RVA: 0x00032403 File Offset: 0x00030603
		public override Action<object, TProperty> CreateFieldSetter<TProperty>(FieldInfo fieldInfo)
		{
			return delegate(object obj, TProperty value)
			{
				fieldInfo.SetValue(obj, value);
			};
		}
	}
}
