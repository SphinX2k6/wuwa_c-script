using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000121 RID: 289
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AIModule.BlackboardComponent")]
	[UnrealStructLayout(464, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 464)]
	public class UBlackboardComponent : UActorComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060014F8 RID: 5368 RVA: 0x0001EE07 File Offset: 0x0001D007
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UBlackboardComponent._ClassPtr;
		}

		// Token: 0x060014F9 RID: 5369 RVA: 0x0001EE14 File Offset: 0x0001D014
		public UBlackboardComponent() : this(BuiltinUtils.AllocNativeUObject(UBlackboardComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060014FA RID: 5370 RVA: 0x0001EE3C File Offset: 0x0001D03C
		[NullableContext(1)]
		public UBlackboardComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UBlackboardComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700059A RID: 1434
		// (get) Token: 0x060014FB RID: 5371 RVA: 0x0001EE6F File Offset: 0x0001D06F
		// (set) Token: 0x060014FC RID: 5372 RVA: 0x0001EE83 File Offset: 0x0001D083
		public unsafe UBrainComponent BrainComp
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBrainComponent>(base.NativePtr / (IntPtr)sizeof(void*) + UBlackboardComponent.__PropertyOffset_BrainComp);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UBlackboardComponent.__PropertyOffset_BrainComp, value);
			}
		}

		// Token: 0x1700059B RID: 1435
		// (get) Token: 0x060014FD RID: 5373 RVA: 0x0001EE98 File Offset: 0x0001D098
		// (set) Token: 0x060014FE RID: 5374 RVA: 0x0001EEAC File Offset: 0x0001D0AC
		public unsafe UBlackboardData DefaultBlackboardAsset
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBlackboardData>(base.NativePtr / (IntPtr)sizeof(void*) + UBlackboardComponent.__PropertyOffset_DefaultBlackboardAsset);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UBlackboardComponent.__PropertyOffset_DefaultBlackboardAsset, value);
			}
		}

		// Token: 0x1700059C RID: 1436
		// (get) Token: 0x060014FF RID: 5375 RVA: 0x0001EEC1 File Offset: 0x0001D0C1
		// (set) Token: 0x06001500 RID: 5376 RVA: 0x0001EED5 File Offset: 0x0001D0D5
		public unsafe UBlackboardData BlackboardAsset
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UBlackboardData>(base.NativePtr / (IntPtr)sizeof(void*) + UBlackboardComponent.__PropertyOffset_BlackboardAsset);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UBlackboardComponent.__PropertyOffset_BlackboardAsset, value);
			}
		}

		// Token: 0x1700059D RID: 1437
		// (get) Token: 0x06001501 RID: 5377 RVA: 0x0001EEEC File Offset: 0x0001D0EC
		// (set) Token: 0x06001502 RID: 5378 RVA: 0x0001EF25 File Offset: 0x0001D125
		[Nullable(1)]
		public TArray<UBlackboardKeyType> KeyInstances
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<UBlackboardKeyType> result;
				if ((result = this._KeyInstances) == null)
				{
					result = (this._KeyInstances = new TArray<UBlackboardKeyType>(base.NativePtr + (IntPtr)UBlackboardComponent.__PropertyOffset_KeyInstances, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.KeyInstances.CopyAssign(value);
			}
		}

		// Token: 0x06001503 RID: 5379 RVA: 0x0001EF34 File Offset: 0x0001D134
		public unsafe void SetValueAsVector(in FName KeyName, FVector VectorValue)
		{
			fixed (FName* ptr = &KeyName)
			{
				void* ptr2 = (void*)ptr;
				UBlackboardComponent.__SetValueAsVector_Internal(base.NativePtr, KeyName, VectorValue);
			}
		}

		// Token: 0x06001504 RID: 5380 RVA: 0x0001EF58 File Offset: 0x0001D158
		[NullableContext(1)]
		public unsafe void SetValueAsString(in FName KeyName, string StringValue)
		{
			FString fstring = FString.AllocTemp(StringValue);
			fixed (FName* ptr = &KeyName)
			{
				void* ptr2 = (void*)ptr;
				UBlackboardComponent.__SetValueAsString_Internal(base.NativePtr, KeyName, fstring);
				FString.NativeDestruct(&fstring, 1);
			}
		}

		// Token: 0x06001505 RID: 5381 RVA: 0x0001EF8C File Offset: 0x0001D18C
		public unsafe void SetValueAsRotator(in FName KeyName, FRotator VectorValue)
		{
			fixed (FName* ptr = &KeyName)
			{
				void* ptr2 = (void*)ptr;
				UBlackboardComponent.__SetValueAsRotator_Internal(base.NativePtr, KeyName, VectorValue);
			}
		}

		// Token: 0x06001506 RID: 5382 RVA: 0x0001EFB0 File Offset: 0x0001D1B0
		public unsafe void SetValueAsObject(in FName KeyName, UObject ObjectValue)
		{
			fixed (FName* ptr = &KeyName)
			{
				void* ptr2 = (void*)ptr;
				UBlackboardComponent.__SetValueAsObject_Internal(base.NativePtr, KeyName, (ObjectValue != null) ? ObjectValue.NativePtr : IntPtr.Zero);
			}
		}

		// Token: 0x06001507 RID: 5383 RVA: 0x0001EFE4 File Offset: 0x0001D1E4
		public unsafe void SetValueAsName(in FName KeyName, FName NameValue)
		{
			fixed (FName* ptr = &KeyName)
			{
				void* ptr2 = (void*)ptr;
				UBlackboardComponent.__SetValueAsName_Internal(base.NativePtr, KeyName, NameValue);
			}
		}

		// Token: 0x06001508 RID: 5384 RVA: 0x0001F008 File Offset: 0x0001D208
		public unsafe void SetValueAsInt(in FName KeyName, int IntValue)
		{
			fixed (FName* ptr = &KeyName)
			{
				void* ptr2 = (void*)ptr;
				UBlackboardComponent.__SetValueAsInt_Internal(base.NativePtr, KeyName, IntValue);
			}
		}

		// Token: 0x06001509 RID: 5385 RVA: 0x0001F02C File Offset: 0x0001D22C
		public unsafe void SetValueAsFloat(in FName KeyName, float FloatValue)
		{
			fixed (FName* ptr = &KeyName)
			{
				void* ptr2 = (void*)ptr;
				UBlackboardComponent.__SetValueAsFloat_Internal(base.NativePtr, KeyName, FloatValue);
			}
		}

		// Token: 0x0600150A RID: 5386 RVA: 0x0001F050 File Offset: 0x0001D250
		public unsafe void SetValueAsEnum(in FName KeyName, byte EnumValue)
		{
			fixed (FName* ptr = &KeyName)
			{
				void* ptr2 = (void*)ptr;
				UBlackboardComponent.__SetValueAsEnum_Internal(base.NativePtr, KeyName, EnumValue);
			}
		}

		// Token: 0x0600150B RID: 5387 RVA: 0x0001F074 File Offset: 0x0001D274
		public unsafe void SetValueAsClass(in FName KeyName, UClassStackOnlyPtr ClassValue)
		{
			fixed (FName* ptr = &KeyName)
			{
				void* ptr2 = (void*)ptr;
				UBlackboardComponent.__SetValueAsClass_Internal(base.NativePtr, KeyName, ClassValue._NativePtr);
			}
		}

		// Token: 0x0600150C RID: 5388 RVA: 0x0001F09C File Offset: 0x0001D29C
		public unsafe void SetValueAsBool(in FName KeyName, bool BoolValue)
		{
			fixed (FName* ptr = &KeyName)
			{
				void* ptr2 = (void*)ptr;
				UBlackboardComponent.__SetValueAsBool_Internal(base.NativePtr, KeyName, BoolValue);
			}
		}

		// Token: 0x0600150D RID: 5389 RVA: 0x0001F0C0 File Offset: 0x0001D2C0
		public unsafe bool IsVectorValueSet(in FName KeyName)
		{
			fixed (FName* ptr = &KeyName)
			{
				void* ptr2 = (void*)ptr;
				return UBlackboardComponent.__IsVectorValueSet_Internal(base.NativePtr, KeyName);
			}
		}

		// Token: 0x0600150E RID: 5390 RVA: 0x0001F0E0 File Offset: 0x0001D2E0
		public unsafe FVector GetValueAsVector(in FName KeyName)
		{
			fixed (FName* ptr = &KeyName)
			{
				void* ptr2 = (void*)ptr;
				return UBlackboardComponent.__GetValueAsVector_Internal(base.NativePtr, KeyName);
			}
		}

		// Token: 0x0600150F RID: 5391 RVA: 0x0001F100 File Offset: 0x0001D300
		[NullableContext(1)]
		public unsafe string GetValueAsString(in FName KeyName)
		{
			fixed (FName* ptr = &KeyName)
			{
				void* ptr2 = (void*)ptr;
				return FString.ToStringAndDeleteNativePtr(UBlackboardComponent.__GetValueAsString_Internal(base.NativePtr, KeyName));
			}
		}

		// Token: 0x06001510 RID: 5392 RVA: 0x0001F124 File Offset: 0x0001D324
		public unsafe FRotator GetValueAsRotator(in FName KeyName)
		{
			fixed (FName* ptr = &KeyName)
			{
				void* ptr2 = (void*)ptr;
				return UBlackboardComponent.__GetValueAsRotator_Internal(base.NativePtr, KeyName);
			}
		}

		// Token: 0x06001511 RID: 5393 RVA: 0x0001F144 File Offset: 0x0001D344
		public unsafe UObject GetValueAsObject(in FName KeyName)
		{
			fixed (FName* ptr = &KeyName)
			{
				void* ptr2 = (void*)ptr;
				return BuiltinUtils.GetOrCreateUObjectByNativePointer<UObject>(UBlackboardComponent.__GetValueAsObject_Internal(base.NativePtr, KeyName));
			}
		}

		// Token: 0x06001512 RID: 5394 RVA: 0x0001F168 File Offset: 0x0001D368
		public unsafe FName GetValueAsName(in FName KeyName)
		{
			fixed (FName* ptr = &KeyName)
			{
				void* ptr2 = (void*)ptr;
				return UBlackboardComponent.__GetValueAsName_Internal(base.NativePtr, KeyName);
			}
		}

		// Token: 0x06001513 RID: 5395 RVA: 0x0001F188 File Offset: 0x0001D388
		public unsafe int GetValueAsInt(in FName KeyName)
		{
			fixed (FName* ptr = &KeyName)
			{
				void* ptr2 = (void*)ptr;
				return UBlackboardComponent.__GetValueAsInt_Internal(base.NativePtr, KeyName);
			}
		}

		// Token: 0x06001514 RID: 5396 RVA: 0x0001F1A8 File Offset: 0x0001D3A8
		public unsafe float GetValueAsFloat(in FName KeyName)
		{
			fixed (FName* ptr = &KeyName)
			{
				void* ptr2 = (void*)ptr;
				return UBlackboardComponent.__GetValueAsFloat_Internal(base.NativePtr, KeyName);
			}
		}

		// Token: 0x06001515 RID: 5397 RVA: 0x0001F1C8 File Offset: 0x0001D3C8
		public unsafe byte GetValueAsEnum(in FName KeyName)
		{
			fixed (FName* ptr = &KeyName)
			{
				void* ptr2 = (void*)ptr;
				return UBlackboardComponent.__GetValueAsEnum_Internal(base.NativePtr, KeyName);
			}
		}

		// Token: 0x06001516 RID: 5398 RVA: 0x0001F1E8 File Offset: 0x0001D3E8
		public unsafe UClassStackOnlyPtr GetValueAsClass(in FName KeyName)
		{
			fixed (FName* ptr = &KeyName)
			{
				void* ptr2 = (void*)ptr;
				return UBlackboardComponent.__GetValueAsClass_Internal(base.NativePtr, KeyName);
			}
		}

		// Token: 0x06001517 RID: 5399 RVA: 0x0001F20C File Offset: 0x0001D40C
		public unsafe bool GetValueAsBool(in FName KeyName)
		{
			fixed (FName* ptr = &KeyName)
			{
				void* ptr2 = (void*)ptr;
				return UBlackboardComponent.__GetValueAsBool_Internal(base.NativePtr, KeyName);
			}
		}

		// Token: 0x06001518 RID: 5400 RVA: 0x0001F22C File Offset: 0x0001D42C
		public unsafe bool GetRotationFromEntry(in FName KeyName, ref FRotator ResultRotation)
		{
			fixed (FName* ptr = &KeyName)
			{
				void* ptr2 = (void*)ptr;
				fixed (FRotator* ptr3 = &ResultRotation)
				{
					void* ptr4 = (void*)ptr3;
					return UBlackboardComponent.__GetRotationFromEntry_Internal(base.NativePtr, KeyName, ref ResultRotation);
				}
			}
		}

		// Token: 0x06001519 RID: 5401 RVA: 0x0001F250 File Offset: 0x0001D450
		public unsafe bool GetLocationFromEntry(in FName KeyName, ref FVector ResultLocation)
		{
			fixed (FName* ptr = &KeyName)
			{
				void* ptr2 = (void*)ptr;
				fixed (FVector* ptr3 = &ResultLocation)
				{
					void* ptr4 = (void*)ptr3;
					return UBlackboardComponent.__GetLocationFromEntry_Internal(base.NativePtr, KeyName, ref ResultLocation);
				}
			}
		}

		// Token: 0x0600151A RID: 5402 RVA: 0x0001F274 File Offset: 0x0001D474
		public unsafe void ClearValue(in FName KeyName)
		{
			fixed (FName* ptr = &KeyName)
			{
				void* ptr2 = (void*)ptr;
				UBlackboardComponent.__ClearValue_Internal(base.NativePtr, KeyName);
			}
		}

		// Token: 0x0600151B RID: 5403
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetValueAsVector_Internal(IntPtr @this, in FName KeyName, FVector VectorValue);

		// Token: 0x0600151C RID: 5404
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetValueAsString_Internal(IntPtr @this, in FName KeyName, in FString StringValue);

		// Token: 0x0600151D RID: 5405
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetValueAsRotator_Internal(IntPtr @this, in FName KeyName, FRotator VectorValue);

		// Token: 0x0600151E RID: 5406
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetValueAsObject_Internal(IntPtr @this, in FName KeyName, IntPtr ObjectValue);

		// Token: 0x0600151F RID: 5407
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetValueAsName_Internal(IntPtr @this, in FName KeyName, FName NameValue);

		// Token: 0x06001520 RID: 5408
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetValueAsInt_Internal(IntPtr @this, in FName KeyName, int IntValue);

		// Token: 0x06001521 RID: 5409
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetValueAsFloat_Internal(IntPtr @this, in FName KeyName, float FloatValue);

		// Token: 0x06001522 RID: 5410
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetValueAsEnum_Internal(IntPtr @this, in FName KeyName, byte EnumValue);

		// Token: 0x06001523 RID: 5411
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetValueAsClass_Internal(IntPtr @this, in FName KeyName, IntPtr ClassValue);

		// Token: 0x06001524 RID: 5412
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetValueAsBool_Internal(IntPtr @this, in FName KeyName, bool BoolValue);

		// Token: 0x06001525 RID: 5413
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsVectorValueSet_Internal(IntPtr @this, in FName KeyName);

		// Token: 0x06001526 RID: 5414
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __GetValueAsVector_Internal(IntPtr @this, in FName KeyName);

		// Token: 0x06001527 RID: 5415
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetValueAsString_Internal(IntPtr @this, in FName KeyName);

		// Token: 0x06001528 RID: 5416
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FRotator __GetValueAsRotator_Internal(IntPtr @this, in FName KeyName);

		// Token: 0x06001529 RID: 5417
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetValueAsObject_Internal(IntPtr @this, in FName KeyName);

		// Token: 0x0600152A RID: 5418
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FName __GetValueAsName_Internal(IntPtr @this, in FName KeyName);

		// Token: 0x0600152B RID: 5419
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetValueAsInt_Internal(IntPtr @this, in FName KeyName);

		// Token: 0x0600152C RID: 5420
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetValueAsFloat_Internal(IntPtr @this, in FName KeyName);

		// Token: 0x0600152D RID: 5421
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern byte __GetValueAsEnum_Internal(IntPtr @this, in FName KeyName);

		// Token: 0x0600152E RID: 5422
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetValueAsClass_Internal(IntPtr @this, in FName KeyName);

		// Token: 0x0600152F RID: 5423
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetValueAsBool_Internal(IntPtr @this, in FName KeyName);

		// Token: 0x06001530 RID: 5424
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetRotationFromEntry_Internal(IntPtr @this, in FName KeyName, ref FRotator ResultRotation);

		// Token: 0x06001531 RID: 5425
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetLocationFromEntry_Internal(IntPtr @this, in FName KeyName, ref FVector ResultLocation);

		// Token: 0x06001532 RID: 5426
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClearValue_Internal(IntPtr @this, in FName KeyName);

		// Token: 0x06001533 RID: 5427 RVA: 0x0001F295 File Offset: 0x0001D495
		static UBlackboardComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AIModule.BlackboardComponent");
		}

		// Token: 0x06001534 RID: 5428 RVA: 0x0001F2A3 File Offset: 0x0001D4A3
		protected UBlackboardComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04000461 RID: 1121
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AIModule.BlackboardComponent";

		// Token: 0x04000462 RID: 1122
		private static IntPtr _ClassPtr;

		// Token: 0x04000463 RID: 1123
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04000464 RID: 1124
		internal static int __PropertyOffset_BrainComp;

		// Token: 0x04000465 RID: 1125
		internal static int __PropertyOffset_DefaultBlackboardAsset;

		// Token: 0x04000466 RID: 1126
		internal static int __PropertyOffset_BlackboardAsset;

		// Token: 0x04000467 RID: 1127
		internal static int __PropertyOffset_KeyInstances;

		// Token: 0x04000468 RID: 1128
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UBlackboardKeyType> _KeyInstances;
	}
}
