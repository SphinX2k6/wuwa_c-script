using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;

namespace System.Text.Json.Reflection
{
	// Token: 0x02000079 RID: 121
	internal static class ReflectionExtensions
	{
		// Token: 0x06000886 RID: 2182 RVA: 0x00027684 File Offset: 0x00025884
		public static Type GetCompatibleGenericBaseClass(this Type type, Type baseType)
		{
			if (baseType == null)
			{
				return null;
			}
			Type type2 = type;
			while (type2 != null && type2 != typeof(object))
			{
				if (type2.IsGenericType && type2.GetGenericTypeDefinition() == baseType)
				{
					return type2;
				}
				type2 = type2.BaseType;
			}
			return null;
		}

		// Token: 0x06000887 RID: 2183 RVA: 0x000276D8 File Offset: 0x000258D8
		[UnconditionalSuppressMessage("ReflectionAnalysis", "IL2070:UnrecognizedReflectionPattern", Justification = "The 'interfaceType' must exist and so trimmer kept it. In which case It also kept it on any type which implements it. The below call to GetInterfaces may return fewer results when trimmed but it will return the 'interfaceType' if the type implemented it, even after trimming.")]
		public static Type GetCompatibleGenericInterface(this Type type, Type interfaceType)
		{
			if (interfaceType == null)
			{
				return null;
			}
			Type type2 = type;
			if (type2.IsGenericType)
			{
				type2 = type2.GetGenericTypeDefinition();
			}
			if (type2 == interfaceType)
			{
				return type;
			}
			foreach (Type type3 in type.GetInterfaces())
			{
				if (type3.IsGenericType && type3.GetGenericTypeDefinition() == interfaceType)
				{
					return type3;
				}
			}
			return null;
		}

		// Token: 0x06000888 RID: 2184 RVA: 0x00027738 File Offset: 0x00025938
		public static bool IsImmutableDictionaryType(this Type type)
		{
			if (!type.IsGenericType || !type.Assembly.FullName.StartsWith("System.Collections.Immutable", StringComparison.Ordinal))
			{
				return false;
			}
			string baseNameFromGenericType = ReflectionExtensions.GetBaseNameFromGenericType(type);
			return baseNameFromGenericType == "System.Collections.Immutable.ImmutableDictionary`2" || baseNameFromGenericType == "System.Collections.Immutable.IImmutableDictionary`2" || baseNameFromGenericType == "System.Collections.Immutable.ImmutableSortedDictionary`2";
		}

		// Token: 0x06000889 RID: 2185 RVA: 0x00027798 File Offset: 0x00025998
		public static bool IsImmutableEnumerableType(this Type type)
		{
			if (!type.IsGenericType || !type.Assembly.FullName.StartsWith("System.Collections.Immutable", StringComparison.Ordinal))
			{
				return false;
			}
			string baseNameFromGenericType = ReflectionExtensions.GetBaseNameFromGenericType(type);
			if (baseNameFromGenericType != null)
			{
				switch (baseNameFromGenericType.Length)
				{
				case 44:
				{
					char c = baseNameFromGenericType[30];
					if (c != 'I')
					{
						if (c != 'm')
						{
							return false;
						}
						if (!(baseNameFromGenericType == "System.Collections.Immutable.ImmutableList`1"))
						{
							return false;
						}
					}
					else if (!(baseNameFromGenericType == "System.Collections.Immutable.IImmutableSet`1"))
					{
						return false;
					}
					break;
				}
				case 45:
				{
					char c = baseNameFromGenericType[38];
					if (c <= 'Q')
					{
						if (c != 'A')
						{
							if (c != 'Q')
							{
								return false;
							}
							if (!(baseNameFromGenericType == "System.Collections.Immutable.ImmutableQueue`1"))
							{
								return false;
							}
						}
						else if (!(baseNameFromGenericType == "System.Collections.Immutable.ImmutableArray`1"))
						{
							return false;
						}
					}
					else if (c != 'S')
					{
						if (c != 'e')
						{
							return false;
						}
						if (!(baseNameFromGenericType == "System.Collections.Immutable.IImmutableList`1"))
						{
							return false;
						}
					}
					else if (!(baseNameFromGenericType == "System.Collections.Immutable.ImmutableStack`1"))
					{
						return false;
					}
					break;
				}
				case 46:
				{
					char c = baseNameFromGenericType[39];
					if (c != 'Q')
					{
						if (c != 'S')
						{
							return false;
						}
						if (!(baseNameFromGenericType == "System.Collections.Immutable.IImmutableStack`1"))
						{
							return false;
						}
					}
					else if (!(baseNameFromGenericType == "System.Collections.Immutable.IImmutableQueue`1"))
					{
						return false;
					}
					break;
				}
				case 47:
					if (!(baseNameFromGenericType == "System.Collections.Immutable.ImmutableHashSet`1"))
					{
						return false;
					}
					break;
				case 48:
					return false;
				case 49:
					if (!(baseNameFromGenericType == "System.Collections.Immutable.ImmutableSortedSet`1"))
					{
						return false;
					}
					break;
				default:
					return false;
				}
				return true;
			}
			return false;
		}

		// Token: 0x0600088A RID: 2186 RVA: 0x000278FC File Offset: 0x00025AFC
		public static string GetImmutableDictionaryConstructingTypeName(this Type type)
		{
			string baseNameFromGenericType = ReflectionExtensions.GetBaseNameFromGenericType(type);
			if (baseNameFromGenericType == "System.Collections.Immutable.ImmutableDictionary`2" || baseNameFromGenericType == "System.Collections.Immutable.IImmutableDictionary`2")
			{
				return "System.Collections.Immutable.ImmutableDictionary";
			}
			if (!(baseNameFromGenericType == "System.Collections.Immutable.ImmutableSortedDictionary`2"))
			{
				return null;
			}
			return "System.Collections.Immutable.ImmutableSortedDictionary";
		}

		// Token: 0x0600088B RID: 2187 RVA: 0x00027948 File Offset: 0x00025B48
		public static string GetImmutableEnumerableConstructingTypeName(this Type type)
		{
			string baseNameFromGenericType = ReflectionExtensions.GetBaseNameFromGenericType(type);
			if (baseNameFromGenericType != null)
			{
				switch (baseNameFromGenericType.Length)
				{
				case 44:
				{
					char c = baseNameFromGenericType[30];
					if (c != 'I')
					{
						if (c != 'm')
						{
							goto IL_165;
						}
						if (!(baseNameFromGenericType == "System.Collections.Immutable.ImmutableList`1"))
						{
							goto IL_165;
						}
					}
					else
					{
						if (!(baseNameFromGenericType == "System.Collections.Immutable.IImmutableSet`1"))
						{
							goto IL_165;
						}
						goto IL_15F;
					}
					break;
				}
				case 45:
				{
					char c = baseNameFromGenericType[38];
					if (c <= 'Q')
					{
						if (c != 'A')
						{
							if (c != 'Q')
							{
								goto IL_165;
							}
							if (!(baseNameFromGenericType == "System.Collections.Immutable.ImmutableQueue`1"))
							{
								goto IL_165;
							}
							goto IL_153;
						}
						else
						{
							if (!(baseNameFromGenericType == "System.Collections.Immutable.ImmutableArray`1"))
							{
								goto IL_165;
							}
							return "System.Collections.Immutable.ImmutableArray";
						}
					}
					else if (c != 'S')
					{
						if (c != 'e')
						{
							goto IL_165;
						}
						if (!(baseNameFromGenericType == "System.Collections.Immutable.IImmutableList`1"))
						{
							goto IL_165;
						}
					}
					else
					{
						if (!(baseNameFromGenericType == "System.Collections.Immutable.ImmutableStack`1"))
						{
							goto IL_165;
						}
						goto IL_14D;
					}
					break;
				}
				case 46:
				{
					char c = baseNameFromGenericType[39];
					if (c != 'Q')
					{
						if (c != 'S')
						{
							goto IL_165;
						}
						if (!(baseNameFromGenericType == "System.Collections.Immutable.IImmutableStack`1"))
						{
							goto IL_165;
						}
						goto IL_14D;
					}
					else
					{
						if (!(baseNameFromGenericType == "System.Collections.Immutable.IImmutableQueue`1"))
						{
							goto IL_165;
						}
						goto IL_153;
					}
					break;
				}
				case 47:
					if (!(baseNameFromGenericType == "System.Collections.Immutable.ImmutableHashSet`1"))
					{
						goto IL_165;
					}
					goto IL_15F;
				case 48:
					goto IL_165;
				case 49:
					if (!(baseNameFromGenericType == "System.Collections.Immutable.ImmutableSortedSet`1"))
					{
						goto IL_165;
					}
					return "System.Collections.Immutable.ImmutableSortedSet";
				default:
					goto IL_165;
				}
				return "System.Collections.Immutable.ImmutableList";
				IL_14D:
				return "System.Collections.Immutable.ImmutableStack";
				IL_153:
				return "System.Collections.Immutable.ImmutableQueue";
				IL_15F:
				return "System.Collections.Immutable.ImmutableHashSet";
			}
			IL_165:
			return null;
		}

		// Token: 0x0600088C RID: 2188 RVA: 0x00027ABB File Offset: 0x00025CBB
		private static string GetBaseNameFromGenericType(Type genericType)
		{
			return genericType.GetGenericTypeDefinition().FullName;
		}

		// Token: 0x0600088D RID: 2189 RVA: 0x00027AC8 File Offset: 0x00025CC8
		public static bool IsVirtual(this PropertyInfo propertyInfo)
		{
			MethodInfo getMethod = propertyInfo.GetMethod;
			if (getMethod == null || !getMethod.IsVirtual)
			{
				MethodInfo setMethod = propertyInfo.SetMethod;
				return setMethod != null && setMethod.IsVirtual;
			}
			return true;
		}

		// Token: 0x0600088E RID: 2190 RVA: 0x00027AF1 File Offset: 0x00025CF1
		public static bool IsKeyValuePair(this Type type)
		{
			return type.IsGenericType && type.GetGenericTypeDefinition() == typeof(KeyValuePair<, >);
		}

		// Token: 0x0600088F RID: 2191 RVA: 0x00027B14 File Offset: 0x00025D14
		public static bool TryGetDeserializationConstructor([DynamicallyAccessedMembers((DynamicallyAccessedMemberTypes)7)] this Type type, bool useDefaultCtorInAnnotatedStructs, out ConstructorInfo deserializationCtor)
		{
			ConstructorInfo constructorInfo = null;
			ConstructorInfo constructorInfo2 = null;
			ConstructorInfo constructorInfo3 = null;
			ConstructorInfo[] constructors = type.GetConstructors(BindingFlags.Instance | BindingFlags.Public);
			if (constructors.Length == 1)
			{
				constructorInfo3 = constructors[0];
			}
			foreach (ConstructorInfo constructorInfo4 in constructors)
			{
				if (ReflectionExtensions.HasJsonConstructorAttribute(constructorInfo4))
				{
					if (constructorInfo != null)
					{
						deserializationCtor = null;
						return false;
					}
					constructorInfo = constructorInfo4;
				}
				else if (constructorInfo4.GetParameters().Length == 0)
				{
					constructorInfo2 = constructorInfo4;
				}
			}
			foreach (ConstructorInfo constructorInfo5 in type.GetConstructors(BindingFlags.Instance | BindingFlags.NonPublic))
			{
				if (ReflectionExtensions.HasJsonConstructorAttribute(constructorInfo5))
				{
					if (constructorInfo != null)
					{
						deserializationCtor = null;
						return false;
					}
					constructorInfo = constructorInfo5;
				}
			}
			if (useDefaultCtorInAnnotatedStructs && type.IsValueType && constructorInfo == null)
			{
				deserializationCtor = null;
				return true;
			}
			ConstructorInfo constructorInfo6;
			if ((constructorInfo6 = constructorInfo) == null)
			{
				constructorInfo6 = (constructorInfo2 ?? constructorInfo3);
			}
			deserializationCtor = constructorInfo6;
			return true;
		}

		// Token: 0x06000890 RID: 2192 RVA: 0x00027BE8 File Offset: 0x00025DE8
		public static object GetDefaultValue(this ParameterInfo parameterInfo)
		{
			Type parameterType = parameterInfo.ParameterType;
			object defaultValue = parameterInfo.DefaultValue;
			if (defaultValue == null)
			{
				return null;
			}
			if (defaultValue == DBNull.Value && parameterType != typeof(DBNull))
			{
				return null;
			}
			if (parameterType.IsEnum)
			{
				return Enum.ToObject(parameterType, defaultValue);
			}
			Type underlyingType = Nullable.GetUnderlyingType(parameterType);
			if (underlyingType != null && underlyingType.IsEnum)
			{
				return Enum.ToObject(underlyingType, defaultValue);
			}
			return defaultValue;
		}

		// Token: 0x06000891 RID: 2193 RVA: 0x00027C50 File Offset: 0x00025E50
		[RequiresUnreferencedCode("Should only be used by the reflection-based serializer.")]
		public static Type[] GetSortedTypeHierarchy(this Type type)
		{
			if (!type.IsInterface)
			{
				List<Type> list = new List<Type>();
				Type type2 = type;
				while (type2 != null)
				{
					list.Add(type2);
					type2 = type2.BaseType;
				}
				return list.ToArray();
			}
			return JsonHelpers.TraverseGraphWithTopologicalSort<Type>(type, (Type t) => t.GetInterfaces(), null);
		}

		// Token: 0x06000892 RID: 2194 RVA: 0x00027CB3 File Offset: 0x00025EB3
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool IsNullableOfT(this Type type)
		{
			return type.IsGenericType && type.GetGenericTypeDefinition() == ReflectionExtensions.s_nullableType;
		}

		// Token: 0x06000893 RID: 2195 RVA: 0x00027CCF File Offset: 0x00025ECF
		public static bool IsNullableType(this Type type)
		{
			return !type.IsValueType || type.IsNullableOfT();
		}

		// Token: 0x06000894 RID: 2196 RVA: 0x00027CE1 File Offset: 0x00025EE1
		public static bool IsAssignableFromInternal(this Type type, Type from)
		{
			if (from.IsNullableOfT() && type.IsInterface)
			{
				return type.IsAssignableFrom(from.GetGenericArguments()[0]);
			}
			return type.IsAssignableFrom(from);
		}

		// Token: 0x06000895 RID: 2197 RVA: 0x00027D09 File Offset: 0x00025F09
		public static bool IsInSubtypeRelationshipWith(this Type type, Type other)
		{
			return type.IsAssignableFromInternal(other) || other.IsAssignableFromInternal(type);
		}

		// Token: 0x06000896 RID: 2198 RVA: 0x00027D1D File Offset: 0x00025F1D
		private static bool HasJsonConstructorAttribute(ConstructorInfo constructorInfo)
		{
			return constructorInfo.GetCustomAttribute<JsonConstructorAttribute>() != null;
		}

		// Token: 0x06000897 RID: 2199 RVA: 0x00027D28 File Offset: 0x00025F28
		public static bool HasRequiredMemberAttribute(this MemberInfo memberInfo)
		{
			return memberInfo.HasCustomAttributeWithName("System.Runtime.CompilerServices.RequiredMemberAttribute", false);
		}

		// Token: 0x06000898 RID: 2200 RVA: 0x00027D36 File Offset: 0x00025F36
		public static bool HasSetsRequiredMembersAttribute(this MemberInfo memberInfo)
		{
			return memberInfo.HasCustomAttributeWithName("System.Diagnostics.CodeAnalysis.SetsRequiredMembersAttribute", false);
		}

		// Token: 0x06000899 RID: 2201 RVA: 0x00027D44 File Offset: 0x00025F44
		private static bool HasCustomAttributeWithName(this MemberInfo memberInfo, string fullName, bool inherit)
		{
			object[] customAttributes = memberInfo.GetCustomAttributes(inherit);
			for (int i = 0; i < customAttributes.Length; i++)
			{
				if (customAttributes[i].GetType().FullName == fullName)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x0600089A RID: 2202 RVA: 0x00027D80 File Offset: 0x00025F80
		public static TAttribute GetUniqueCustomAttribute<TAttribute>(this MemberInfo memberInfo, bool inherit) where TAttribute : Attribute
		{
			object[] customAttributes = memberInfo.GetCustomAttributes(typeof(TAttribute), inherit);
			if (customAttributes.Length == 0)
			{
				return default(TAttribute);
			}
			if (customAttributes.Length == 1)
			{
				return (TAttribute)((object)customAttributes[0]);
			}
			ThrowHelper.ThrowInvalidOperationException_SerializationDuplicateAttribute(typeof(TAttribute), memberInfo);
			return default(TAttribute);
		}

		// Token: 0x0600089B RID: 2203 RVA: 0x00027DD5 File Offset: 0x00025FD5
		public static object CreateInstanceNoWrapExceptions([DynamicallyAccessedMembers((DynamicallyAccessedMemberTypes)7)] this Type type, Type[] parameterTypes, object[] parameters)
		{
			return type.GetConstructor(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, parameterTypes, null).Invoke(BindingFlags.DoNotWrapExceptions, null, parameters, null);
		}

		// Token: 0x0400024E RID: 590
		private static readonly Type s_nullableType = typeof(Nullable<>);
	}
}
