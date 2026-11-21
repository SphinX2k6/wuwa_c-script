using System;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000047 RID: 71
	[NullableContext(1)]
	[Nullable(0)]
	public static class NativeArrayProcessorFactory
	{
		// Token: 0x060008AC RID: 2220 RVA: 0x0000DC98 File Offset: 0x0000BE98
		private static object GetOrCreateGenericProcessor(Type ProcessType, Type SrcType, bool SrcTypeIsGenericAndUseFirst)
		{
			object obj;
			if (!NativeArrayProcessorFactory._DynamicArrayProcessor.TryGetValue(SrcType, out obj))
			{
				obj = Activator.CreateInstance(ProcessType.MakeGenericType(new Type[]
				{
					SrcTypeIsGenericAndUseFirst ? SrcType.GetGenericArguments()[0] : SrcType
				}));
				NativeArrayProcessorFactory._DynamicArrayProcessor.TryAdd(SrcType, obj);
			}
			return obj;
		}

		// Token: 0x060008AD RID: 2221 RVA: 0x0000DCE8 File Offset: 0x0000BEE8
		public static NativeArrayProcessorBase<T> GetProcessor<[Nullable(2)] T>()
		{
			Type typeFromHandle = typeof(T);
			UnrealReflectionPropertyTypeCode typeCode = UnrealReflectionPropertyType.GetTypeCode(typeFromHandle);
			if (typeCode <= UnrealReflectionPropertyTypeCode.Map)
			{
				if (typeCode <= UnrealReflectionPropertyTypeCode.ULong)
				{
					if (typeCode <= UnrealReflectionPropertyTypeCode.UShort)
					{
						ulong num = typeCode - UnrealReflectionPropertyTypeCode.Bool;
						if (num <= 3UL)
						{
							switch ((uint)num)
							{
							case 0U:
								return Unsafe.As<NativeArrayProcessorBase<T>>(NativeArrayProcessorFactory.s_BoolProcessor);
							case 1U:
							case 3U:
								goto IL_31F;
							case 2U:
								goto IL_4FE;
							}
						}
						if (typeCode != UnrealReflectionPropertyTypeCode.Short && typeCode != UnrealReflectionPropertyTypeCode.UShort)
						{
							goto IL_4FE;
						}
					}
					else if (typeCode <= UnrealReflectionPropertyTypeCode.UInt)
					{
						if (typeCode != UnrealReflectionPropertyTypeCode.Int && typeCode != UnrealReflectionPropertyTypeCode.UInt)
						{
							goto IL_4FE;
						}
					}
					else if (typeCode != UnrealReflectionPropertyTypeCode.Long && typeCode != UnrealReflectionPropertyTypeCode.ULong)
					{
						goto IL_4FE;
					}
					IL_31F:
					if (typeFromHandle.IsEnum)
					{
						return (NativeArrayProcessorBase<T>)NativeArrayProcessorFactory.GetOrCreateGenericProcessor(typeof(EnumArrayProcessor<>), typeFromHandle, false);
					}
					if (typeCode <= UnrealReflectionPropertyTypeCode.UShort)
					{
						if (typeCode <= UnrealReflectionPropertyTypeCode.Byte)
						{
							if (typeCode == UnrealReflectionPropertyTypeCode.Sbyte)
							{
								return Unsafe.As<NativeArrayProcessorBase<T>>(NativeArrayProcessorFactory.s_SByteProcessor);
							}
							if (typeCode == UnrealReflectionPropertyTypeCode.Byte)
							{
								return Unsafe.As<NativeArrayProcessorBase<T>>(NativeArrayProcessorFactory.s_ByteProcessor);
							}
						}
						else
						{
							if (typeCode == UnrealReflectionPropertyTypeCode.Short)
							{
								return Unsafe.As<NativeArrayProcessorBase<T>>(NativeArrayProcessorFactory.s_Int16Processor);
							}
							if (typeCode == UnrealReflectionPropertyTypeCode.UShort)
							{
								return Unsafe.As<NativeArrayProcessorBase<T>>(NativeArrayProcessorFactory.s_UInt16Processor);
							}
						}
					}
					else if (typeCode <= UnrealReflectionPropertyTypeCode.UInt)
					{
						if (typeCode == UnrealReflectionPropertyTypeCode.Int)
						{
							return Unsafe.As<NativeArrayProcessorBase<T>>(NativeArrayProcessorFactory.s_Int32Processor);
						}
						if (typeCode == UnrealReflectionPropertyTypeCode.UInt)
						{
							return Unsafe.As<NativeArrayProcessorBase<T>>(NativeArrayProcessorFactory.s_UInt32Processor);
						}
					}
					else
					{
						if (typeCode == UnrealReflectionPropertyTypeCode.Long)
						{
							return Unsafe.As<NativeArrayProcessorBase<T>>(NativeArrayProcessorFactory.s_Int64Processor);
						}
						if (typeCode == UnrealReflectionPropertyTypeCode.ULong)
						{
							return Unsafe.As<NativeArrayProcessorBase<T>>(NativeArrayProcessorFactory.s_UInt64Processor);
						}
					}
					throw new UnreachableException();
				}
				else if (typeCode <= UnrealReflectionPropertyTypeCode.Name)
				{
					if (typeCode <= UnrealReflectionPropertyTypeCode.Double)
					{
						if (typeCode == UnrealReflectionPropertyTypeCode.Float)
						{
							return Unsafe.As<NativeArrayProcessorBase<T>>(NativeArrayProcessorFactory.s_FloatProcessor);
						}
						if (typeCode == UnrealReflectionPropertyTypeCode.Double)
						{
							return Unsafe.As<NativeArrayProcessorBase<T>>(NativeArrayProcessorFactory.s_DoubleProcessor);
						}
					}
					else
					{
						if (typeCode == UnrealReflectionPropertyTypeCode.String)
						{
							return Unsafe.As<NativeArrayProcessorBase<T>>(NativeArrayProcessorFactory.s_stringProcessor);
						}
						if (typeCode == UnrealReflectionPropertyTypeCode.Name)
						{
							return Unsafe.As<NativeArrayProcessorBase<T>>(NativeArrayProcessorFactory.s_FNameProcessor);
						}
					}
				}
				else if (typeCode <= UnrealReflectionPropertyTypeCode.Array)
				{
					if (typeCode == UnrealReflectionPropertyTypeCode.Text)
					{
						return Unsafe.As<NativeArrayProcessorBase<T>>(NativeArrayProcessorFactory.s_FTextProcessor);
					}
					if (typeCode != UnrealReflectionPropertyTypeCode.Array)
					{
					}
				}
				else if (typeCode != UnrealReflectionPropertyTypeCode.Set && typeCode != UnrealReflectionPropertyTypeCode.Map)
				{
				}
			}
			else
			{
				if (typeCode <= UnrealReflectionPropertyTypeCode.Delegate)
				{
					if (typeCode <= UnrealReflectionPropertyTypeCode.SoftObject)
					{
						if (typeCode <= UnrealReflectionPropertyTypeCode.SoftClass)
						{
							if (typeCode == UnrealReflectionPropertyTypeCode.Class)
							{
								goto IL_4FE;
							}
							if (typeCode != UnrealReflectionPropertyTypeCode.SoftClass)
							{
								goto IL_4FE;
							}
						}
						else
						{
							if (typeCode == UnrealReflectionPropertyTypeCode.WeakObject)
							{
								goto IL_426;
							}
							if (typeCode != UnrealReflectionPropertyTypeCode.SoftObject)
							{
								goto IL_4FE;
							}
						}
						return (NativeArrayProcessorBase<T>)NativeArrayProcessorFactory.GetOrCreateGenericProcessor(typeof(UnrealStructProxyArrayProcessor<>), typeFromHandle, false);
					}
					if (typeCode <= UnrealReflectionPropertyTypeCode.FieldPath)
					{
						if (typeCode != UnrealReflectionPropertyTypeCode.LazyObject)
						{
							if (typeCode != UnrealReflectionPropertyTypeCode.FieldPath)
							{
								goto IL_4FE;
							}
							goto IL_4FE;
						}
					}
					else if (typeCode != UnrealReflectionPropertyTypeCode.Interface)
					{
						if (typeCode != UnrealReflectionPropertyTypeCode.Delegate)
						{
							goto IL_4FE;
						}
						goto IL_4FE;
					}
					else
					{
						if (typeFromHandle == typeof(FScriptInterface))
						{
							return Unsafe.As<NativeArrayProcessorBase<T>>(NativeArrayProcessorFactory.s_FScriptInterfaceProcessor);
						}
						if (typeFromHandle.GetInterface("IUnrealBlueprintInterface") != null)
						{
							return (NativeArrayProcessorBase<T>)NativeArrayProcessorFactory.GetOrCreateGenericProcessor(typeof(UnrealBlueprintInterfaceArrayProcessor<>), typeFromHandle, false);
						}
						if (typeFromHandle.GetInterface("IUnrealNativeInterface") != null)
						{
							return (NativeArrayProcessorBase<T>)NativeArrayProcessorFactory.GetOrCreateGenericProcessor(typeof(UnrealNativeInterfaceArrayProcessor<>), typeFromHandle, false);
						}
						return (NativeArrayProcessorBase<T>)NativeArrayProcessorFactory.GetOrCreateGenericProcessor(typeof(TScriptInterfaceArrayProcessor<>), typeFromHandle, true);
					}
					IL_426:
					return (NativeArrayProcessorBase<T>)NativeArrayProcessorFactory.GetOrCreateGenericProcessor(typeof(BlittableUnrealStructArrayProcessor<>), typeFromHandle, false);
				}
				if (typeCode <= UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)
				{
					if (typeCode <= UnrealReflectionPropertyTypeCode.MulticastSparseDelegate)
					{
						if (typeCode != UnrealReflectionPropertyTypeCode.MulticastInlineDelegate && typeCode != UnrealReflectionPropertyTypeCode.MulticastSparseDelegate)
						{
							goto IL_4FE;
						}
						goto IL_4FE;
					}
					else
					{
						if (typeCode == UnrealReflectionPropertyTypeCode.MulticastDelegate)
						{
							goto IL_4FE;
						}
						if (typeCode != UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)
						{
							goto IL_4FE;
						}
					}
				}
				else if (typeCode <= UnrealReflectionPropertyTypeCode.UnrealObject)
				{
					if (typeCode != UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy)
					{
						if (typeCode != UnrealReflectionPropertyTypeCode.UnrealObject)
						{
							goto IL_4FE;
						}
						return (NativeArrayProcessorBase<T>)NativeArrayProcessorFactory.GetOrCreateGenericProcessor(typeof(UnrealUObjectArrayProcessor<>), typeFromHandle, false);
					}
				}
				else
				{
					if (typeCode == UnrealReflectionPropertyTypeCode.EnumAsByte)
					{
						return (NativeArrayProcessorBase<T>)NativeArrayProcessorFactory.GetOrCreateGenericProcessor(typeof(TEnumAsByteArrayProcessor<>), typeFromHandle, true);
					}
					if (typeCode != (UnrealReflectionPropertyTypeCode)(-2147483648))
					{
						goto IL_4FE;
					}
					return (NativeArrayProcessorBase<T>)NativeArrayProcessorFactory.GetOrCreateGenericProcessor(typeof(TSubclassOfArrayProcessor<>), typeFromHandle, true);
				}
				PropertyInfo property = typeof(NativeArrayProcessorFactory).GetProperty(typeFromHandle.Name + "_ArrayProcessor", BindingFlags.Static | BindingFlags.NonPublic);
				if (property == null)
				{
					if ((typeCode & UnrealReflectionPropertyTypeCode.UnrealProxyObject) != UnrealReflectionPropertyTypeCode.Unusable)
					{
						return (NativeArrayProcessorBase<T>)NativeArrayProcessorFactory.GetOrCreateGenericProcessor(typeof(UnrealScriptStructProxyArrayProcessor<>), typeFromHandle, false);
					}
					if (typeCode == UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)
					{
						if (typeFromHandle.GetInterface("IUnrealScriptStruct") != null)
						{
							return (NativeArrayProcessorBase<T>)NativeArrayProcessorFactory.GetOrCreateGenericProcessor(typeof(BlittableUnrealScriptStructArrayProcessor<>), typeFromHandle, false);
						}
						return (NativeArrayProcessorBase<T>)NativeArrayProcessorFactory.GetOrCreateGenericProcessor(typeof(BlittableUnrealStructArrayProcessor<>), typeFromHandle, false);
					}
				}
				return (NativeArrayProcessorBase<T>)property.GetValue(null);
			}
			IL_4FE:
			throw new NotImplementedException("Unsupported type " + typeFromHandle.FullName);
		}

		// Token: 0x060008AE RID: 2222 RVA: 0x0000E208 File Offset: 0x0000C408
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void AddRef(object Processor)
		{
			IScriptStructProcessor scriptStructProcessor = Processor as IScriptStructProcessor;
			if (scriptStructProcessor != null)
			{
				BuiltinUtils.AddRefForUUserDefinedStruct(scriptStructProcessor.GetNativeScriptStructPtr());
			}
		}

		// Token: 0x060008AF RID: 2223 RVA: 0x0000E230 File Offset: 0x0000C430
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void DecRef(object Processor)
		{
			IScriptStructProcessor scriptStructProcessor = Processor as IScriptStructProcessor;
			if (scriptStructProcessor != null)
			{
				BuiltinUtils.DecRefForUUserDefinedStruct(scriptStructProcessor.GetNativeScriptStructPtr());
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x060008B0 RID: 2224 RVA: 0x0000E257 File Offset: 0x0000C457
		private static BlittableUnrealScriptStructArrayProcessor<FBox> FBox_ArrayProcessor
		{
			get
			{
				return new BlittableUnrealScriptStructArrayProcessor<FBox>();
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x060008B1 RID: 2225 RVA: 0x0000E25E File Offset: 0x0000C45E
		private static BlittableUnrealScriptStructArrayProcessor<FColor> FColor_ArrayProcessor
		{
			get
			{
				return new BlittableUnrealScriptStructArrayProcessor<FColor>();
			}
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x060008B2 RID: 2226 RVA: 0x0000E265 File Offset: 0x0000C465
		private static BlittableUnrealScriptStructArrayProcessor<FFloatRange> FFloatRange_ArrayProcessor
		{
			get
			{
				return new BlittableUnrealScriptStructArrayProcessor<FFloatRange>();
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x060008B3 RID: 2227 RVA: 0x0000E26C File Offset: 0x0000C46C
		private static BlittableUnrealScriptStructArrayProcessor<FGameplayTag> FGameplayTag_ArrayProcessor
		{
			get
			{
				return new BlittableUnrealScriptStructArrayProcessor<FGameplayTag>();
			}
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x060008B4 RID: 2228 RVA: 0x0000E273 File Offset: 0x0000C473
		private static BlittableUnrealScriptStructArrayProcessor<FGuid> FGuid_ArrayProcessor
		{
			get
			{
				return new BlittableUnrealScriptStructArrayProcessor<FGuid>();
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x060008B5 RID: 2229 RVA: 0x0000E27A File Offset: 0x0000C47A
		private static BlittableUnrealScriptStructArrayProcessor<FInterpCurvePointFloat> FInterpCurvePointFloat_ArrayProcessor
		{
			get
			{
				return new BlittableUnrealScriptStructArrayProcessor<FInterpCurvePointFloat>();
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x060008B6 RID: 2230 RVA: 0x0000E281 File Offset: 0x0000C481
		private static BlittableUnrealScriptStructArrayProcessor<FInterpCurvePointLinearColor> FInterpCurvePointLinearColor_ArrayProcessor
		{
			get
			{
				return new BlittableUnrealScriptStructArrayProcessor<FInterpCurvePointLinearColor>();
			}
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x060008B7 RID: 2231 RVA: 0x0000E288 File Offset: 0x0000C488
		private static BlittableUnrealScriptStructArrayProcessor<FInterpCurvePointTwoVectors> FInterpCurvePointTwoVectors_ArrayProcessor
		{
			get
			{
				return new BlittableUnrealScriptStructArrayProcessor<FInterpCurvePointTwoVectors>();
			}
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x060008B8 RID: 2232 RVA: 0x0000E28F File Offset: 0x0000C48F
		private static BlittableUnrealScriptStructArrayProcessor<FInterpCurvePointVector> FInterpCurvePointVector_ArrayProcessor
		{
			get
			{
				return new BlittableUnrealScriptStructArrayProcessor<FInterpCurvePointVector>();
			}
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x060008B9 RID: 2233 RVA: 0x0000E296 File Offset: 0x0000C496
		private static BlittableUnrealScriptStructArrayProcessor<FInterpCurvePointVector2D> FInterpCurvePointVector2D_ArrayProcessor
		{
			get
			{
				return new BlittableUnrealScriptStructArrayProcessor<FInterpCurvePointVector2D>();
			}
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x060008BA RID: 2234 RVA: 0x0000E29D File Offset: 0x0000C49D
		private static BlittableUnrealScriptStructArrayProcessor<FIntPoint> FIntPoint_ArrayProcessor
		{
			get
			{
				return new BlittableUnrealScriptStructArrayProcessor<FIntPoint>();
			}
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x060008BB RID: 2235 RVA: 0x0000E2A4 File Offset: 0x0000C4A4
		private static BlittableUnrealScriptStructArrayProcessor<FKuroBuildingGridCellVector> FKuroBuildingGridCellVector_ArrayProcessor
		{
			get
			{
				return new BlittableUnrealScriptStructArrayProcessor<FKuroBuildingGridCellVector>();
			}
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x060008BC RID: 2236 RVA: 0x0000E2AB File Offset: 0x0000C4AB
		private static BlittableUnrealScriptStructArrayProcessor<FKuroSceneTeamItem> FKuroSceneTeamItem_ArrayProcessor
		{
			get
			{
				return new BlittableUnrealScriptStructArrayProcessor<FKuroSceneTeamItem>();
			}
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x060008BD RID: 2237 RVA: 0x0000E2B2 File Offset: 0x0000C4B2
		private static BlittableUnrealScriptStructArrayProcessor<FLinearColor> FLinearColor_ArrayProcessor
		{
			get
			{
				return new BlittableUnrealScriptStructArrayProcessor<FLinearColor>();
			}
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x060008BE RID: 2238 RVA: 0x0000E2B9 File Offset: 0x0000C4B9
		private static BlittableUnrealScriptStructArrayProcessor<FMatrix> FMatrix_ArrayProcessor
		{
			get
			{
				return new BlittableUnrealScriptStructArrayProcessor<FMatrix>();
			}
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x060008BF RID: 2239 RVA: 0x0000E2C0 File Offset: 0x0000C4C0
		private static BlittableUnrealScriptStructArrayProcessor<FObjectPoolInstanceConfig> FObjectPoolInstanceConfig_ArrayProcessor
		{
			get
			{
				return new BlittableUnrealScriptStructArrayProcessor<FObjectPoolInstanceConfig>();
			}
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x060008C0 RID: 2240 RVA: 0x0000E2C7 File Offset: 0x0000C4C7
		private static BlittableUnrealScriptStructArrayProcessor<FQuat> FQuat_ArrayProcessor
		{
			get
			{
				return new BlittableUnrealScriptStructArrayProcessor<FQuat>();
			}
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x060008C1 RID: 2241 RVA: 0x0000E2CE File Offset: 0x0000C4CE
		private static BlittableUnrealScriptStructArrayProcessor<FRichCurveKey> FRichCurveKey_ArrayProcessor
		{
			get
			{
				return new BlittableUnrealScriptStructArrayProcessor<FRichCurveKey>();
			}
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x060008C2 RID: 2242 RVA: 0x0000E2D5 File Offset: 0x0000C4D5
		private static BlittableUnrealScriptStructArrayProcessor<FRotator> FRotator_ArrayProcessor
		{
			get
			{
				return new BlittableUnrealScriptStructArrayProcessor<FRotator>();
			}
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x060008C3 RID: 2243 RVA: 0x0000E2DC File Offset: 0x0000C4DC
		private static BlittableUnrealScriptStructArrayProcessor<FTransform> FTransform_ArrayProcessor
		{
			get
			{
				return new BlittableUnrealScriptStructArrayProcessor<FTransform>();
			}
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x060008C4 RID: 2244 RVA: 0x0000E2E3 File Offset: 0x0000C4E3
		private static BlittableUnrealScriptStructArrayProcessor<FTransformDouble> FTransformDouble_ArrayProcessor
		{
			get
			{
				return new BlittableUnrealScriptStructArrayProcessor<FTransformDouble>();
			}
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x060008C5 RID: 2245 RVA: 0x0000E2EA File Offset: 0x0000C4EA
		private static BlittableUnrealScriptStructArrayProcessor<FVector> FVector_ArrayProcessor
		{
			get
			{
				return new BlittableUnrealScriptStructArrayProcessor<FVector>();
			}
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x060008C6 RID: 2246 RVA: 0x0000E2F1 File Offset: 0x0000C4F1
		private static BlittableUnrealScriptStructArrayProcessor<FVector2D> FVector2D_ArrayProcessor
		{
			get
			{
				return new BlittableUnrealScriptStructArrayProcessor<FVector2D>();
			}
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x060008C7 RID: 2247 RVA: 0x0000E2F8 File Offset: 0x0000C4F8
		private static BlittableUnrealScriptStructArrayProcessor<FVector4> FVector4_ArrayProcessor
		{
			get
			{
				return new BlittableUnrealScriptStructArrayProcessor<FVector4>();
			}
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x060008C8 RID: 2248 RVA: 0x0000E2FF File Offset: 0x0000C4FF
		private static BlittableUnrealScriptStructArrayProcessor<FVectorDouble> FVectorDouble_ArrayProcessor
		{
			get
			{
				return new BlittableUnrealScriptStructArrayProcessor<FVectorDouble>();
			}
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x060008C9 RID: 2249 RVA: 0x0000E306 File Offset: 0x0000C506
		private static UnrealScriptStructProxyArrayProcessor<FAbilityTriggerData> FAbilityTriggerData_ArrayProcessor
		{
			get
			{
				return new UnrealScriptStructProxyArrayProcessor<FAbilityTriggerData>();
			}
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x060008CA RID: 2250 RVA: 0x0000E30D File Offset: 0x0000C50D
		private static UnrealScriptStructProxyArrayProcessor<FAchievementStruct> FAchievementStruct_ArrayProcessor
		{
			get
			{
				return new UnrealScriptStructProxyArrayProcessor<FAchievementStruct>();
			}
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x060008CB RID: 2251 RVA: 0x0000E314 File Offset: 0x0000C514
		private static UnrealScriptStructProxyArrayProcessor<FActiveCameraShakeInfo> FActiveCameraShakeInfo_ArrayProcessor
		{
			get
			{
				return new UnrealScriptStructProxyArrayProcessor<FActiveCameraShakeInfo>();
			}
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x060008CC RID: 2252 RVA: 0x0000E31B File Offset: 0x0000C51B
		private static UnrealScriptStructProxyArrayProcessor<FActiveGameplayEffectHandle> FActiveGameplayEffectHandle_ArrayProcessor
		{
			get
			{
				return new UnrealScriptStructProxyArrayProcessor<FActiveGameplayEffectHandle>();
			}
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x060008CD RID: 2253 RVA: 0x0000E322 File Offset: 0x0000C522
		private static UnrealScriptStructProxyArrayProcessor<FAnimNotifyEvent> FAnimNotifyEvent_ArrayProcessor
		{
			get
			{
				return new UnrealScriptStructProxyArrayProcessor<FAnimNotifyEvent>();
			}
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x060008CE RID: 2254 RVA: 0x0000E329 File Offset: 0x0000C529
		private static UnrealScriptStructProxyArrayProcessor<FAnimSegment> FAnimSegment_ArrayProcessor
		{
			get
			{
				return new UnrealScriptStructProxyArrayProcessor<FAnimSegment>();
			}
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x060008CF RID: 2255 RVA: 0x0000E330 File Offset: 0x0000C530
		private static UnrealScriptStructProxyArrayProcessor<FAnimSlotGroup> FAnimSlotGroup_ArrayProcessor
		{
			get
			{
				return new UnrealScriptStructProxyArrayProcessor<FAnimSlotGroup>();
			}
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x060008D0 RID: 2256 RVA: 0x0000E337 File Offset: 0x0000C537
		private static UnrealScriptStructProxyArrayProcessor<FAssetBundleEntry> FAssetBundleEntry_ArrayProcessor
		{
			get
			{
				return new UnrealScriptStructProxyArrayProcessor<FAssetBundleEntry>();
			}
		}

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x060008D1 RID: 2257 RVA: 0x0000E33E File Offset: 0x0000C53E
		private static UnrealScriptStructProxyArrayProcessor<FAssetData> FAssetData_ArrayProcessor
		{
			get
			{
				return new UnrealScriptStructProxyArrayProcessor<FAssetData>();
			}
		}

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x060008D2 RID: 2258 RVA: 0x0000E345 File Offset: 0x0000C545
		private static UnrealScriptStructProxyArrayProcessor<FBTCompositeChild> FBTCompositeChild_ArrayProcessor
		{
			get
			{
				return new UnrealScriptStructProxyArrayProcessor<FBTCompositeChild>();
			}
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x060008D3 RID: 2259 RVA: 0x0000E34C File Offset: 0x0000C54C
		private static UnrealScriptStructProxyArrayProcessor<FBtSaveLoadRecordItem> FBtSaveLoadRecordItem_ArrayProcessor
		{
			get
			{
				return new UnrealScriptStructProxyArrayProcessor<FBtSaveLoadRecordItem>();
			}
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x060008D4 RID: 2260 RVA: 0x0000E353 File Offset: 0x0000C553
		private static UnrealScriptStructProxyArrayProcessor<FBulletHitWorldEntityOperation> FBulletHitWorldEntityOperation_ArrayProcessor
		{
			get
			{
				return new UnrealScriptStructProxyArrayProcessor<FBulletHitWorldEntityOperation>();
			}
		}

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x060008D5 RID: 2261 RVA: 0x0000E35A File Offset: 0x0000C55A
		private static UnrealScriptStructProxyArrayProcessor<FCompositeSection> FCompositeSection_ArrayProcessor
		{
			get
			{
				return new UnrealScriptStructProxyArrayProcessor<FCompositeSection>();
			}
		}

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x060008D6 RID: 2262 RVA: 0x0000E361 File Offset: 0x0000C561
		private static UnrealScriptStructProxyArrayProcessor<FEngineShowFlagsSetting> FEngineShowFlagsSetting_ArrayProcessor
		{
			get
			{
				return new UnrealScriptStructProxyArrayProcessor<FEngineShowFlagsSetting>();
			}
		}

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x060008D7 RID: 2263 RVA: 0x0000E368 File Offset: 0x0000C568
		private static UnrealScriptStructProxyArrayProcessor<FExtraMaterialInfo> FExtraMaterialInfo_ArrayProcessor
		{
			get
			{
				return new UnrealScriptStructProxyArrayProcessor<FExtraMaterialInfo>();
			}
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x060008D8 RID: 2264 RVA: 0x0000E36F File Offset: 0x0000C56F
		private static UnrealScriptStructProxyArrayProcessor<FFrameNumber> FFrameNumber_ArrayProcessor
		{
			get
			{
				return new UnrealScriptStructProxyArrayProcessor<FFrameNumber>();
			}
		}

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x060008D9 RID: 2265 RVA: 0x0000E376 File Offset: 0x0000C576
		private static UnrealScriptStructProxyArrayProcessor<FGameBudgetBlueprintGroupConfig> FGameBudgetBlueprintGroupConfig_ArrayProcessor
		{
			get
			{
				return new UnrealScriptStructProxyArrayProcessor<FGameBudgetBlueprintGroupConfig>();
			}
		}

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x060008DA RID: 2266 RVA: 0x0000E37D File Offset: 0x0000C57D
		private static UnrealScriptStructProxyArrayProcessor<FGamePartitionObject> FGamePartitionObject_ArrayProcessor
		{
			get
			{
				return new UnrealScriptStructProxyArrayProcessor<FGamePartitionObject>();
			}
		}

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x060008DB RID: 2267 RVA: 0x0000E384 File Offset: 0x0000C584
		private static UnrealScriptStructProxyArrayProcessor<FGameplayTagContainer> FGameplayTagContainer_ArrayProcessor
		{
			get
			{
				return new UnrealScriptStructProxyArrayProcessor<FGameplayTagContainer>();
			}
		}

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x060008DC RID: 2268 RVA: 0x0000E38B File Offset: 0x0000C58B
		private static UnrealScriptStructProxyArrayProcessor<FHitResult> FHitResult_ArrayProcessor
		{
			get
			{
				return new UnrealScriptStructProxyArrayProcessor<FHitResult>();
			}
		}

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x060008DD RID: 2269 RVA: 0x0000E392 File Offset: 0x0000C592
		private static UnrealScriptStructProxyArrayProcessor<FInputActionKeyMapping> FInputActionKeyMapping_ArrayProcessor
		{
			get
			{
				return new UnrealScriptStructProxyArrayProcessor<FInputActionKeyMapping>();
			}
		}

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x060008DE RID: 2270 RVA: 0x0000E399 File Offset: 0x0000C599
		private static UnrealScriptStructProxyArrayProcessor<FInputAxisKeyMapping> FInputAxisKeyMapping_ArrayProcessor
		{
			get
			{
				return new UnrealScriptStructProxyArrayProcessor<FInputAxisKeyMapping>();
			}
		}

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x060008DF RID: 2271 RVA: 0x0000E3A0 File Offset: 0x0000C5A0
		private static UnrealScriptStructProxyArrayProcessor<FInterpCurvePointQuat> FInterpCurvePointQuat_ArrayProcessor
		{
			get
			{
				return new UnrealScriptStructProxyArrayProcessor<FInterpCurvePointQuat>();
			}
		}

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x060008E0 RID: 2272 RVA: 0x0000E3A7 File Offset: 0x0000C5A7
		private static UnrealScriptStructProxyArrayProcessor<FKey> FKey_ArrayProcessor
		{
			get
			{
				return new UnrealScriptStructProxyArrayProcessor<FKey>();
			}
		}

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x060008E1 RID: 2273 RVA: 0x0000E3AE File Offset: 0x0000C5AE
		private static UnrealScriptStructProxyArrayProcessor<FKSC_HeadHpContext> FKSC_HeadHpContext_ArrayProcessor
		{
			get
			{
				return new UnrealScriptStructProxyArrayProcessor<FKSC_HeadHpContext>();
			}
		}

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x060008E2 RID: 2274 RVA: 0x0000E3B5 File Offset: 0x0000C5B5
		private static UnrealScriptStructProxyArrayProcessor<FKSC_LandFireContext> FKSC_LandFireContext_ArrayProcessor
		{
			get
			{
				return new UnrealScriptStructProxyArrayProcessor<FKSC_LandFireContext>();
			}
		}

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x060008E3 RID: 2275 RVA: 0x0000E3BC File Offset: 0x0000C5BC
		private static UnrealScriptStructProxyArrayProcessor<FKSC_MiniMapContext> FKSC_MiniMapContext_ArrayProcessor
		{
			get
			{
				return new UnrealScriptStructProxyArrayProcessor<FKSC_MiniMapContext>();
			}
		}

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x060008E4 RID: 2276 RVA: 0x0000E3C3 File Offset: 0x0000C5C3
		private static UnrealScriptStructProxyArrayProcessor<FKSC_RemoveContext> FKSC_RemoveContext_ArrayProcessor
		{
			get
			{
				return new UnrealScriptStructProxyArrayProcessor<FKSC_RemoveContext>();
			}
		}

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x060008E5 RID: 2277 RVA: 0x0000E3CA File Offset: 0x0000C5CA
		private static UnrealScriptStructProxyArrayProcessor<FKSC_Segment> FKSC_Segment_ArrayProcessor
		{
			get
			{
				return new UnrealScriptStructProxyArrayProcessor<FKSC_Segment>();
			}
		}

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x060008E6 RID: 2278 RVA: 0x0000E3D1 File Offset: 0x0000C5D1
		private static UnrealScriptStructProxyArrayProcessor<FKSC_Shape2D_DamageTotalInfo> FKSC_Shape2D_DamageTotalInfo_ArrayProcessor
		{
			get
			{
				return new UnrealScriptStructProxyArrayProcessor<FKSC_Shape2D_DamageTotalInfo>();
			}
		}

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x060008E7 RID: 2279 RVA: 0x0000E3D8 File Offset: 0x0000C5D8
		private static UnrealScriptStructProxyArrayProcessor<FKSC_SpawnEntity> FKSC_SpawnEntity_ArrayProcessor
		{
			get
			{
				return new UnrealScriptStructProxyArrayProcessor<FKSC_SpawnEntity>();
			}
		}

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x060008E8 RID: 2280 RVA: 0x0000E3DF File Offset: 0x0000C5DF
		private static UnrealScriptStructProxyArrayProcessor<FKSCDamageRelated> FKSCDamageRelated_ArrayProcessor
		{
			get
			{
				return new UnrealScriptStructProxyArrayProcessor<FKSCDamageRelated>();
			}
		}

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x060008E9 RID: 2281 RVA: 0x0000E3E6 File Offset: 0x0000C5E6
		private static UnrealScriptStructProxyArrayProcessor<FKuroBoneTranslationCurveExportInfo> FKuroBoneTranslationCurveExportInfo_ArrayProcessor
		{
			get
			{
				return new UnrealScriptStructProxyArrayProcessor<FKuroBoneTranslationCurveExportInfo>();
			}
		}

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x060008EA RID: 2282 RVA: 0x0000E3ED File Offset: 0x0000C5ED
		private static UnrealScriptStructProxyArrayProcessor<FKuroCheckInfoEntry> FKuroCheckInfoEntry_ArrayProcessor
		{
			get
			{
				return new UnrealScriptStructProxyArrayProcessor<FKuroCheckInfoEntry>();
			}
		}

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x060008EB RID: 2283 RVA: 0x0000E3F4 File Offset: 0x0000C5F4
		private static UnrealScriptStructProxyArrayProcessor<FKuroCrowdAiAnimSequenceConfig> FKuroCrowdAiAnimSequenceConfig_ArrayProcessor
		{
			get
			{
				return new UnrealScriptStructProxyArrayProcessor<FKuroCrowdAiAnimSequenceConfig>();
			}
		}

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x060008EC RID: 2284 RVA: 0x0000E3FB File Offset: 0x0000C5FB
		private static UnrealScriptStructProxyArrayProcessor<FKuroCurveFloat> FKuroCurveFloat_ArrayProcessor
		{
			get
			{
				return new UnrealScriptStructProxyArrayProcessor<FKuroCurveFloat>();
			}
		}

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x060008ED RID: 2285 RVA: 0x0000E402 File Offset: 0x0000C602
		private static UnrealScriptStructProxyArrayProcessor<FKuroCurveLinearColor> FKuroCurveLinearColor_ArrayProcessor
		{
			get
			{
				return new UnrealScriptStructProxyArrayProcessor<FKuroCurveLinearColor>();
			}
		}

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x060008EE RID: 2286 RVA: 0x0000E409 File Offset: 0x0000C609
		private static UnrealScriptStructProxyArrayProcessor<FKuroEffectSpecChildData> FKuroEffectSpecChildData_ArrayProcessor
		{
			get
			{
				return new UnrealScriptStructProxyArrayProcessor<FKuroEffectSpecChildData>();
			}
		}

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x060008EF RID: 2287 RVA: 0x0000E410 File Offset: 0x0000C610
		private static UnrealScriptStructProxyArrayProcessor<FKuroEffectSpecData> FKuroEffectSpecData_ArrayProcessor
		{
			get
			{
				return new UnrealScriptStructProxyArrayProcessor<FKuroEffectSpecData>();
			}
		}

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x060008F0 RID: 2288 RVA: 0x0000E417 File Offset: 0x0000C617
		private static UnrealScriptStructProxyArrayProcessor<FKuroGeometrySimplePolygon> FKuroGeometrySimplePolygon_ArrayProcessor
		{
			get
			{
				return new UnrealScriptStructProxyArrayProcessor<FKuroGeometrySimplePolygon>();
			}
		}

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x060008F1 RID: 2289 RVA: 0x0000E41E File Offset: 0x0000C61E
		private static UnrealScriptStructProxyArrayProcessor<FKuroNpcFootprintEventData> FKuroNpcFootprintEventData_ArrayProcessor
		{
			get
			{
				return new UnrealScriptStructProxyArrayProcessor<FKuroNpcFootprintEventData>();
			}
		}

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x060008F2 RID: 2290 RVA: 0x0000E425 File Offset: 0x0000C625
		private static UnrealScriptStructProxyArrayProcessor<FKuroParameterArrayVector> FKuroParameterArrayVector_ArrayProcessor
		{
			get
			{
				return new UnrealScriptStructProxyArrayProcessor<FKuroParameterArrayVector>();
			}
		}

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x060008F3 RID: 2291 RVA: 0x0000E42C File Offset: 0x0000C62C
		private static UnrealScriptStructProxyArrayProcessor<FKuroParameterFloat> FKuroParameterFloat_ArrayProcessor
		{
			get
			{
				return new UnrealScriptStructProxyArrayProcessor<FKuroParameterFloat>();
			}
		}

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x060008F4 RID: 2292 RVA: 0x0000E433 File Offset: 0x0000C633
		private static UnrealScriptStructProxyArrayProcessor<FKuroParameterLinearColor> FKuroParameterLinearColor_ArrayProcessor
		{
			get
			{
				return new UnrealScriptStructProxyArrayProcessor<FKuroParameterLinearColor>();
			}
		}

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x060008F5 RID: 2293 RVA: 0x0000E43A File Offset: 0x0000C63A
		private static UnrealScriptStructProxyArrayProcessor<FKuroParameterVector> FKuroParameterVector_ArrayProcessor
		{
			get
			{
				return new UnrealScriptStructProxyArrayProcessor<FKuroParameterVector>();
			}
		}

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x060008F6 RID: 2294 RVA: 0x0000E441 File Offset: 0x0000C641
		private static UnrealScriptStructProxyArrayProcessor<FKuroRequestDownloadInfo> FKuroRequestDownloadInfo_ArrayProcessor
		{
			get
			{
				return new UnrealScriptStructProxyArrayProcessor<FKuroRequestDownloadInfo>();
			}
		}

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x060008F7 RID: 2295 RVA: 0x0000E448 File Offset: 0x0000C648
		private static UnrealScriptStructProxyArrayProcessor<FKuroRhythmGameNote> FKuroRhythmGameNote_ArrayProcessor
		{
			get
			{
				return new UnrealScriptStructProxyArrayProcessor<FKuroRhythmGameNote>();
			}
		}

		// Token: 0x1700006B RID: 107
		// (get) Token: 0x060008F8 RID: 2296 RVA: 0x0000E44F File Offset: 0x0000C64F
		private static UnrealScriptStructProxyArrayProcessor<FKuroRhythmSkillEffectParam> FKuroRhythmSkillEffectParam_ArrayProcessor
		{
			get
			{
				return new UnrealScriptStructProxyArrayProcessor<FKuroRhythmSkillEffectParam>();
			}
		}

		// Token: 0x1700006C RID: 108
		// (get) Token: 0x060008F9 RID: 2297 RVA: 0x0000E456 File Offset: 0x0000C656
		private static UnrealScriptStructProxyArrayProcessor<FMorphTargetPreviewItem> FMorphTargetPreviewItem_ArrayProcessor
		{
			get
			{
				return new UnrealScriptStructProxyArrayProcessor<FMorphTargetPreviewItem>();
			}
		}

		// Token: 0x1700006D RID: 109
		// (get) Token: 0x060008FA RID: 2298 RVA: 0x0000E45D File Offset: 0x0000C65D
		private static UnrealScriptStructProxyArrayProcessor<FMotorBodyShapeConfig> FMotorBodyShapeConfig_ArrayProcessor
		{
			get
			{
				return new UnrealScriptStructProxyArrayProcessor<FMotorBodyShapeConfig>();
			}
		}

		// Token: 0x1700006E RID: 110
		// (get) Token: 0x060008FB RID: 2299 RVA: 0x0000E464 File Offset: 0x0000C664
		private static UnrealScriptStructProxyArrayProcessor<FMotorWheelDisplayInfo> FMotorWheelDisplayInfo_ArrayProcessor
		{
			get
			{
				return new UnrealScriptStructProxyArrayProcessor<FMotorWheelDisplayInfo>();
			}
		}

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x060008FC RID: 2300 RVA: 0x0000E46B File Offset: 0x0000C66B
		private static UnrealScriptStructProxyArrayProcessor<FMovieSceneBinding> FMovieSceneBinding_ArrayProcessor
		{
			get
			{
				return new UnrealScriptStructProxyArrayProcessor<FMovieSceneBinding>();
			}
		}

		// Token: 0x17000070 RID: 112
		// (get) Token: 0x060008FD RID: 2301 RVA: 0x0000E472 File Offset: 0x0000C672
		private static UnrealScriptStructProxyArrayProcessor<FMovieSceneEvent> FMovieSceneEvent_ArrayProcessor
		{
			get
			{
				return new UnrealScriptStructProxyArrayProcessor<FMovieSceneEvent>();
			}
		}

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x060008FE RID: 2302 RVA: 0x0000E479 File Offset: 0x0000C679
		private static UnrealScriptStructProxyArrayProcessor<FMovieSceneFloatValue> FMovieSceneFloatValue_ArrayProcessor
		{
			get
			{
				return new UnrealScriptStructProxyArrayProcessor<FMovieSceneFloatValue>();
			}
		}

		// Token: 0x17000072 RID: 114
		// (get) Token: 0x060008FF RID: 2303 RVA: 0x0000E480 File Offset: 0x0000C680
		private static UnrealScriptStructProxyArrayProcessor<FMovieSceneMarkedFrame> FMovieSceneMarkedFrame_ArrayProcessor
		{
			get
			{
				return new UnrealScriptStructProxyArrayProcessor<FMovieSceneMarkedFrame>();
			}
		}

		// Token: 0x17000073 RID: 115
		// (get) Token: 0x06000900 RID: 2304 RVA: 0x0000E487 File Offset: 0x0000C687
		private static UnrealScriptStructProxyArrayProcessor<FMovieSceneMechanismEvent> FMovieSceneMechanismEvent_ArrayProcessor
		{
			get
			{
				return new UnrealScriptStructProxyArrayProcessor<FMovieSceneMechanismEvent>();
			}
		}

		// Token: 0x17000074 RID: 116
		// (get) Token: 0x06000901 RID: 2305 RVA: 0x0000E48E File Offset: 0x0000C68E
		private static UnrealScriptStructProxyArrayProcessor<FMovieSceneObjectBindingID> FMovieSceneObjectBindingID_ArrayProcessor
		{
			get
			{
				return new UnrealScriptStructProxyArrayProcessor<FMovieSceneObjectBindingID>();
			}
		}

		// Token: 0x17000075 RID: 117
		// (get) Token: 0x06000902 RID: 2306 RVA: 0x0000E495 File Offset: 0x0000C695
		private static UnrealScriptStructProxyArrayProcessor<FMovieScenePossessable> FMovieScenePossessable_ArrayProcessor
		{
			get
			{
				return new UnrealScriptStructProxyArrayProcessor<FMovieScenePossessable>();
			}
		}

		// Token: 0x17000076 RID: 118
		// (get) Token: 0x06000903 RID: 2307 RVA: 0x0000E49C File Offset: 0x0000C69C
		private static UnrealScriptStructProxyArrayProcessor<FMovieSceneQteParams> FMovieSceneQteParams_ArrayProcessor
		{
			get
			{
				return new UnrealScriptStructProxyArrayProcessor<FMovieSceneQteParams>();
			}
		}

		// Token: 0x17000077 RID: 119
		// (get) Token: 0x06000904 RID: 2308 RVA: 0x0000E4A3 File Offset: 0x0000C6A3
		private static UnrealScriptStructProxyArrayProcessor<FMovieSceneSpawnable> FMovieSceneSpawnable_ArrayProcessor
		{
			get
			{
				return new UnrealScriptStructProxyArrayProcessor<FMovieSceneSpawnable>();
			}
		}

		// Token: 0x17000078 RID: 120
		// (get) Token: 0x06000905 RID: 2309 RVA: 0x0000E4AA File Offset: 0x0000C6AA
		private static UnrealScriptStructProxyArrayProcessor<FMovieSceneSubQteParams> FMovieSceneSubQteParams_ArrayProcessor
		{
			get
			{
				return new UnrealScriptStructProxyArrayProcessor<FMovieSceneSubQteParams>();
			}
		}

		// Token: 0x17000079 RID: 121
		// (get) Token: 0x06000906 RID: 2310 RVA: 0x0000E4B1 File Offset: 0x0000C6B1
		private static UnrealScriptStructProxyArrayProcessor<FMovieSceneTrackEvaluationFieldEntry> FMovieSceneTrackEvaluationFieldEntry_ArrayProcessor
		{
			get
			{
				return new UnrealScriptStructProxyArrayProcessor<FMovieSceneTrackEvaluationFieldEntry>();
			}
		}

		// Token: 0x1700007A RID: 122
		// (get) Token: 0x06000907 RID: 2311 RVA: 0x0000E4B8 File Offset: 0x0000C6B8
		private static UnrealScriptStructProxyArrayProcessor<FNamedFilmbackPreset> FNamedFilmbackPreset_ArrayProcessor
		{
			get
			{
				return new UnrealScriptStructProxyArrayProcessor<FNamedFilmbackPreset>();
			}
		}

		// Token: 0x1700007B RID: 123
		// (get) Token: 0x06000908 RID: 2312 RVA: 0x0000E4BF File Offset: 0x0000C6BF
		private static UnrealScriptStructProxyArrayProcessor<FNamedLensPreset> FNamedLensPreset_ArrayProcessor
		{
			get
			{
				return new UnrealScriptStructProxyArrayProcessor<FNamedLensPreset>();
			}
		}

		// Token: 0x1700007C RID: 124
		// (get) Token: 0x06000909 RID: 2313 RVA: 0x0000E4C6 File Offset: 0x0000C6C6
		private static UnrealScriptStructProxyArrayProcessor<FNiagaraAssetInfoEntry> FNiagaraAssetInfoEntry_ArrayProcessor
		{
			get
			{
				return new UnrealScriptStructProxyArrayProcessor<FNiagaraAssetInfoEntry>();
			}
		}

		// Token: 0x1700007D RID: 125
		// (get) Token: 0x0600090A RID: 2314 RVA: 0x0000E4CD File Offset: 0x0000C6CD
		private static UnrealScriptStructProxyArrayProcessor<FOverlapActorRecord> FOverlapActorRecord_ArrayProcessor
		{
			get
			{
				return new UnrealScriptStructProxyArrayProcessor<FOverlapActorRecord>();
			}
		}

		// Token: 0x1700007E RID: 126
		// (get) Token: 0x0600090B RID: 2315 RVA: 0x0000E4D4 File Offset: 0x0000C6D4
		private static UnrealScriptStructProxyArrayProcessor<FPostProcessSettings> FPostProcessSettings_ArrayProcessor
		{
			get
			{
				return new UnrealScriptStructProxyArrayProcessor<FPostProcessSettings>();
			}
		}

		// Token: 0x1700007F RID: 127
		// (get) Token: 0x0600090C RID: 2316 RVA: 0x0000E4DB File Offset: 0x0000C6DB
		private static UnrealScriptStructProxyArrayProcessor<FPredictProjectilePathPointData> FPredictProjectilePathPointData_ArrayProcessor
		{
			get
			{
				return new UnrealScriptStructProxyArrayProcessor<FPredictProjectilePathPointData>();
			}
		}

		// Token: 0x17000080 RID: 128
		// (get) Token: 0x0600090D RID: 2317 RVA: 0x0000E4E2 File Offset: 0x0000C6E2
		private static UnrealScriptStructProxyArrayProcessor<FPrimaryAssetId> FPrimaryAssetId_ArrayProcessor
		{
			get
			{
				return new UnrealScriptStructProxyArrayProcessor<FPrimaryAssetId>();
			}
		}

		// Token: 0x17000081 RID: 129
		// (get) Token: 0x0600090E RID: 2318 RVA: 0x0000E4E9 File Offset: 0x0000C6E9
		private static UnrealScriptStructProxyArrayProcessor<FPrimaryAssetType> FPrimaryAssetType_ArrayProcessor
		{
			get
			{
				return new UnrealScriptStructProxyArrayProcessor<FPrimaryAssetType>();
			}
		}

		// Token: 0x17000082 RID: 130
		// (get) Token: 0x0600090F RID: 2319 RVA: 0x0000E4F0 File Offset: 0x0000C6F0
		private static UnrealScriptStructProxyArrayProcessor<FProductData> FProductData_ArrayProcessor
		{
			get
			{
				return new UnrealScriptStructProxyArrayProcessor<FProductData>();
			}
		}

		// Token: 0x17000083 RID: 131
		// (get) Token: 0x06000910 RID: 2320 RVA: 0x0000E4F7 File Offset: 0x0000C6F7
		private static UnrealScriptStructProxyArrayProcessor<FQteProgressSpineSegment> FQteProgressSpineSegment_ArrayProcessor
		{
			get
			{
				return new UnrealScriptStructProxyArrayProcessor<FQteProgressSpineSegment>();
			}
		}

		// Token: 0x17000084 RID: 132
		// (get) Token: 0x06000911 RID: 2321 RVA: 0x0000E4FE File Offset: 0x0000C6FE
		private static UnrealScriptStructProxyArrayProcessor<FReadFileData> FReadFileData_ArrayProcessor
		{
			get
			{
				return new UnrealScriptStructProxyArrayProcessor<FReadFileData>();
			}
		}

		// Token: 0x17000085 RID: 133
		// (get) Token: 0x06000912 RID: 2322 RVA: 0x0000E505 File Offset: 0x0000C705
		private static UnrealScriptStructProxyArrayProcessor<FRegisteredDeviceInfo> FRegisteredDeviceInfo_ArrayProcessor
		{
			get
			{
				return new UnrealScriptStructProxyArrayProcessor<FRegisteredDeviceInfo>();
			}
		}

		// Token: 0x17000086 RID: 134
		// (get) Token: 0x06000913 RID: 2323 RVA: 0x0000E50C File Offset: 0x0000C70C
		private static UnrealScriptStructProxyArrayProcessor<FRoadSegmentInfo> FRoadSegmentInfo_ArrayProcessor
		{
			get
			{
				return new UnrealScriptStructProxyArrayProcessor<FRoadSegmentInfo>();
			}
		}

		// Token: 0x17000087 RID: 135
		// (get) Token: 0x06000914 RID: 2324 RVA: 0x0000E513 File Offset: 0x0000C713
		private static UnrealScriptStructProxyArrayProcessor<FSequencerBindingRuntimeProxy> FSequencerBindingRuntimeProxy_ArrayProcessor
		{
			get
			{
				return new UnrealScriptStructProxyArrayProcessor<FSequencerBindingRuntimeProxy>();
			}
		}

		// Token: 0x17000088 RID: 136
		// (get) Token: 0x06000915 RID: 2325 RVA: 0x0000E51A File Offset: 0x0000C71A
		private static UnrealScriptStructProxyArrayProcessor<FSharpherealReflectionFunctionGenerateDefine> FSharpherealReflectionFunctionGenerateDefine_ArrayProcessor
		{
			get
			{
				return new UnrealScriptStructProxyArrayProcessor<FSharpherealReflectionFunctionGenerateDefine>();
			}
		}

		// Token: 0x17000089 RID: 137
		// (get) Token: 0x06000916 RID: 2326 RVA: 0x0000E521 File Offset: 0x0000C721
		private static UnrealScriptStructProxyArrayProcessor<FSharpherealReflectionFunctionParamGenerateDefine> FSharpherealReflectionFunctionParamGenerateDefine_ArrayProcessor
		{
			get
			{
				return new UnrealScriptStructProxyArrayProcessor<FSharpherealReflectionFunctionParamGenerateDefine>();
			}
		}

		// Token: 0x1700008A RID: 138
		// (get) Token: 0x06000917 RID: 2327 RVA: 0x0000E528 File Offset: 0x0000C728
		private static UnrealScriptStructProxyArrayProcessor<FSharpherealReflectionPropertyGenerateDefine> FSharpherealReflectionPropertyGenerateDefine_ArrayProcessor
		{
			get
			{
				return new UnrealScriptStructProxyArrayProcessor<FSharpherealReflectionPropertyGenerateDefine>();
			}
		}

		// Token: 0x1700008B RID: 139
		// (get) Token: 0x06000918 RID: 2328 RVA: 0x0000E52F File Offset: 0x0000C72F
		private static UnrealScriptStructProxyArrayProcessor<FSharpherealReflectionPropertyTypeGenerateDefine> FSharpherealReflectionPropertyTypeGenerateDefine_ArrayProcessor
		{
			get
			{
				return new UnrealScriptStructProxyArrayProcessor<FSharpherealReflectionPropertyTypeGenerateDefine>();
			}
		}

		// Token: 0x1700008C RID: 140
		// (get) Token: 0x06000919 RID: 2329 RVA: 0x0000E536 File Offset: 0x0000C736
		private static UnrealScriptStructProxyArrayProcessor<FSharpherealTestSimpleStruct> FSharpherealTestSimpleStruct_ArrayProcessor
		{
			get
			{
				return new UnrealScriptStructProxyArrayProcessor<FSharpherealTestSimpleStruct>();
			}
		}

		// Token: 0x1700008D RID: 141
		// (get) Token: 0x0600091A RID: 2330 RVA: 0x0000E53D File Offset: 0x0000C73D
		private static UnrealScriptStructProxyArrayProcessor<FSkeletalMaterial> FSkeletalMaterial_ArrayProcessor
		{
			get
			{
				return new UnrealScriptStructProxyArrayProcessor<FSkeletalMaterial>();
			}
		}

		// Token: 0x1700008E RID: 142
		// (get) Token: 0x0600091B RID: 2331 RVA: 0x0000E544 File Offset: 0x0000C744
		private static UnrealScriptStructProxyArrayProcessor<FSkelMeshComponentLODInfo> FSkelMeshComponentLODInfo_ArrayProcessor
		{
			get
			{
				return new UnrealScriptStructProxyArrayProcessor<FSkelMeshComponentLODInfo>();
			}
		}

		// Token: 0x1700008F RID: 143
		// (get) Token: 0x0600091C RID: 2332 RVA: 0x0000E54B File Offset: 0x0000C74B
		private static UnrealScriptStructProxyArrayProcessor<FSkelMeshSkinWeightInfo> FSkelMeshSkinWeightInfo_ArrayProcessor
		{
			get
			{
				return new UnrealScriptStructProxyArrayProcessor<FSkelMeshSkinWeightInfo>();
			}
		}

		// Token: 0x17000090 RID: 144
		// (get) Token: 0x0600091D RID: 2333 RVA: 0x0000E552 File Offset: 0x0000C752
		private static UnrealScriptStructProxyArrayProcessor<FSlotAnimationTrack> FSlotAnimationTrack_ArrayProcessor
		{
			get
			{
				return new UnrealScriptStructProxyArrayProcessor<FSlotAnimationTrack>();
			}
		}

		// Token: 0x17000091 RID: 145
		// (get) Token: 0x0600091E RID: 2334 RVA: 0x0000E559 File Offset: 0x0000C759
		private static UnrealScriptStructProxyArrayProcessor<FSoftClassPath> FSoftClassPath_ArrayProcessor
		{
			get
			{
				return new UnrealScriptStructProxyArrayProcessor<FSoftClassPath>();
			}
		}

		// Token: 0x17000092 RID: 146
		// (get) Token: 0x0600091F RID: 2335 RVA: 0x0000E560 File Offset: 0x0000C760
		private static UnrealScriptStructProxyArrayProcessor<FSoftObjectPath> FSoftObjectPath_ArrayProcessor
		{
			get
			{
				return new UnrealScriptStructProxyArrayProcessor<FSoftObjectPath>();
			}
		}

		// Token: 0x17000093 RID: 147
		// (get) Token: 0x06000920 RID: 2336 RVA: 0x0000E567 File Offset: 0x0000C767
		private static UnrealScriptStructProxyArrayProcessor<FSpineData> FSpineData_ArrayProcessor
		{
			get
			{
				return new UnrealScriptStructProxyArrayProcessor<FSpineData>();
			}
		}

		// Token: 0x17000094 RID: 148
		// (get) Token: 0x06000921 RID: 2337 RVA: 0x0000E56E File Offset: 0x0000C76E
		private static UnrealScriptStructProxyArrayProcessor<FSplinePoint> FSplinePoint_ArrayProcessor
		{
			get
			{
				return new UnrealScriptStructProxyArrayProcessor<FSplinePoint>();
			}
		}

		// Token: 0x17000095 RID: 149
		// (get) Token: 0x06000922 RID: 2338 RVA: 0x0000E575 File Offset: 0x0000C775
		private static UnrealScriptStructProxyArrayProcessor<FStaticMeshSourceModel> FStaticMeshSourceModel_ArrayProcessor
		{
			get
			{
				return new UnrealScriptStructProxyArrayProcessor<FStaticMeshSourceModel>();
			}
		}

		// Token: 0x17000096 RID: 150
		// (get) Token: 0x06000923 RID: 2339 RVA: 0x0000E57C File Offset: 0x0000C77C
		private static UnrealScriptStructProxyArrayProcessor<FStreamingSourceShape> FStreamingSourceShape_ArrayProcessor
		{
			get
			{
				return new UnrealScriptStructProxyArrayProcessor<FStreamingSourceShape>();
			}
		}

		// Token: 0x17000097 RID: 151
		// (get) Token: 0x06000924 RID: 2340 RVA: 0x0000E583 File Offset: 0x0000C783
		private static UnrealScriptStructProxyArrayProcessor<FTagAndValue> FTagAndValue_ArrayProcessor
		{
			get
			{
				return new UnrealScriptStructProxyArrayProcessor<FTagAndValue>();
			}
		}

		// Token: 0x17000098 RID: 152
		// (get) Token: 0x06000925 RID: 2341 RVA: 0x0000E58A File Offset: 0x0000C78A
		private static UnrealScriptStructProxyArrayProcessor<FTextureParameterValue> FTextureParameterValue_ArrayProcessor
		{
			get
			{
				return new UnrealScriptStructProxyArrayProcessor<FTextureParameterValue>();
			}
		}

		// Token: 0x17000099 RID: 153
		// (get) Token: 0x06000926 RID: 2342 RVA: 0x0000E591 File Offset: 0x0000C791
		private static UnrealScriptStructProxyArrayProcessor<FTrophyData> FTrophyData_ArrayProcessor
		{
			get
			{
				return new UnrealScriptStructProxyArrayProcessor<FTrophyData>();
			}
		}

		// Token: 0x1700009A RID: 154
		// (get) Token: 0x06000927 RID: 2343 RVA: 0x0000E598 File Offset: 0x0000C798
		private static UnrealScriptStructProxyArrayProcessor<FTrophyDetailData> FTrophyDetailData_ArrayProcessor
		{
			get
			{
				return new UnrealScriptStructProxyArrayProcessor<FTrophyDetailData>();
			}
		}

		// Token: 0x1700009B RID: 155
		// (get) Token: 0x06000928 RID: 2344 RVA: 0x0000E59F File Offset: 0x0000C79F
		private static UnrealScriptStructProxyArrayProcessor<FUIDropdownOptionData> FUIDropdownOptionData_ArrayProcessor
		{
			get
			{
				return new UnrealScriptStructProxyArrayProcessor<FUIDropdownOptionData>();
			}
		}

		// Token: 0x1700009C RID: 156
		// (get) Token: 0x06000929 RID: 2345 RVA: 0x0000E5A6 File Offset: 0x0000C7A6
		private static UnrealScriptStructProxyArrayProcessor<FVertexOffsetUsage> FVertexOffsetUsage_ArrayProcessor
		{
			get
			{
				return new UnrealScriptStructProxyArrayProcessor<FVertexOffsetUsage>();
			}
		}

		// Token: 0x1700009D RID: 157
		// (get) Token: 0x0600092A RID: 2346 RVA: 0x0000E5AD File Offset: 0x0000C7AD
		private static UnrealScriptStructProxyArrayProcessor<FWorldPartitionStreamingQuerySource> FWorldPartitionStreamingQuerySource_ArrayProcessor
		{
			get
			{
				return new UnrealScriptStructProxyArrayProcessor<FWorldPartitionStreamingQuerySource>();
			}
		}

		// Token: 0x1700009E RID: 158
		// (get) Token: 0x0600092B RID: 2347 RVA: 0x0000E5B4 File Offset: 0x0000C7B4
		private static UnrealScriptStructProxyArrayProcessor<FXboxAchievementInfo> FXboxAchievementInfo_ArrayProcessor
		{
			get
			{
				return new UnrealScriptStructProxyArrayProcessor<FXboxAchievementInfo>();
			}
		}

		// Token: 0x1700009F RID: 159
		// (get) Token: 0x0600092C RID: 2348 RVA: 0x0000E5BB File Offset: 0x0000C7BB
		private static UnrealScriptStructProxyArrayProcessor<FXboxRecentPlayerUpdate> FXboxRecentPlayerUpdate_ArrayProcessor
		{
			get
			{
				return new UnrealScriptStructProxyArrayProcessor<FXboxRecentPlayerUpdate>();
			}
		}

		// Token: 0x170000A0 RID: 160
		// (get) Token: 0x0600092D RID: 2349 RVA: 0x0000E5C2 File Offset: 0x0000C7C2
		private static UnrealDelegateProxyArrayProcessor<FSharpherealTestDynDelegate0> FSharpherealTestDynDelegate0_ArrayProcessor
		{
			get
			{
				return new UnrealDelegateProxyArrayProcessor<FSharpherealTestDynDelegate0>(40, 8);
			}
		}

		// Token: 0x04000120 RID: 288
		private static readonly ConcurrentDictionary<Type, object> _DynamicArrayProcessor = new ConcurrentDictionary<Type, object>();

		// Token: 0x04000121 RID: 289
		private static readonly BoolArrayProcessor s_BoolProcessor = new BoolArrayProcessor();

		// Token: 0x04000122 RID: 290
		private static readonly BlittableBuiltinTypeArrayProcessor<byte> s_ByteProcessor = new BlittableBuiltinTypeArrayProcessor<byte>();

		// Token: 0x04000123 RID: 291
		private static readonly BlittableBuiltinTypeArrayProcessor<sbyte> s_SByteProcessor = new BlittableBuiltinTypeArrayProcessor<sbyte>();

		// Token: 0x04000124 RID: 292
		private static readonly BlittableBuiltinTypeArrayProcessor<short> s_Int16Processor = new BlittableBuiltinTypeArrayProcessor<short>();

		// Token: 0x04000125 RID: 293
		private static readonly BlittableBuiltinTypeArrayProcessor<ushort> s_UInt16Processor = new BlittableBuiltinTypeArrayProcessor<ushort>();

		// Token: 0x04000126 RID: 294
		private static readonly BlittableBuiltinTypeArrayProcessor<int> s_Int32Processor = new BlittableBuiltinTypeArrayProcessor<int>();

		// Token: 0x04000127 RID: 295
		private static readonly BlittableBuiltinTypeArrayProcessor<uint> s_UInt32Processor = new BlittableBuiltinTypeArrayProcessor<uint>();

		// Token: 0x04000128 RID: 296
		private static readonly BlittableBuiltinTypeArrayProcessor<long> s_Int64Processor = new BlittableBuiltinTypeArrayProcessor<long>();

		// Token: 0x04000129 RID: 297
		private static readonly BlittableBuiltinTypeArrayProcessor<ulong> s_UInt64Processor = new BlittableBuiltinTypeArrayProcessor<ulong>();

		// Token: 0x0400012A RID: 298
		private static readonly BlittableBuiltinTypeArrayProcessor<float> s_FloatProcessor = new BlittableBuiltinTypeArrayProcessor<float>();

		// Token: 0x0400012B RID: 299
		private static readonly BlittableBuiltinTypeArrayProcessor<double> s_DoubleProcessor = new BlittableBuiltinTypeArrayProcessor<double>();

		// Token: 0x0400012C RID: 300
		private static readonly BlittableUnrealStructArrayProcessor<FName> s_FNameProcessor = new BlittableUnrealStructArrayProcessor<FName>();

		// Token: 0x0400012D RID: 301
		private static readonly StringArrayProcessor s_stringProcessor = new StringArrayProcessor();

		// Token: 0x0400012E RID: 302
		private static readonly FTextArrayProcessor s_FTextProcessor = new FTextArrayProcessor();

		// Token: 0x0400012F RID: 303
		internal static readonly BlittableUnrealStructArrayProcessor<FScriptInterface> s_FScriptInterfaceProcessor = new BlittableUnrealStructArrayProcessor<FScriptInterface>();
	}
}
