using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002025 RID: 8229
	[UnrealObjectPath("/Script/LGUI.LGUIBehaviour")]
	[UnrealStructLayout(272, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 272)]
	public abstract class ULGUIBehaviour : UActorComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601EFFC RID: 126972 RVA: 0x002E17E9 File Offset: 0x002DF9E9
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ULGUIBehaviour._ClassPtr;
		}

		// Token: 0x17007B5C RID: 31580
		// (get) Token: 0x0601EFFD RID: 126973 RVA: 0x002E17F5 File Offset: 0x002DF9F5
		// (set) Token: 0x0601EFFE RID: 126974 RVA: 0x002E1805 File Offset: 0x002DFA05
		public unsafe bool enable
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULGUIBehaviour.__PropertyOffset_enable) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULGUIBehaviour.__PropertyOffset_enable) = (value ? 1 : 0);
			}
		}

		// Token: 0x17007B5D RID: 31581
		// (get) Token: 0x0601EFFF RID: 126975 RVA: 0x002E1818 File Offset: 0x002DFA18
		// (set) Token: 0x0601F000 RID: 126976 RVA: 0x002E1851 File Offset: 0x002DFA51
		[Nullable(1)]
		public FLGUIBehaviourLateUpdateDelegate OnLateUpdate
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FLGUIBehaviourLateUpdateDelegate result;
				if ((result = this._OnLateUpdate) == null)
				{
					result = (this._OnLateUpdate = new FLGUIBehaviourLateUpdateDelegate(base.NativePtr + (IntPtr)ULGUIBehaviour.__PropertyOffset_OnLateUpdate, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				FScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)ULGUIBehaviour.__PropertyOffset_OnLateUpdate, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17007B5E RID: 31582
		// (get) Token: 0x0601F001 RID: 126977 RVA: 0x002E1872 File Offset: 0x002DFA72
		// (set) Token: 0x0601F002 RID: 126978 RVA: 0x002E1886 File Offset: 0x002DFA86
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TWeakObjectPtr<UUIItem> RootUIComp
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)ULGUIBehaviour.__PropertyOffset_RootUIComp);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)ULGUIBehaviour.__PropertyOffset_RootUIComp) = value;
			}
		}

		// Token: 0x0601F003 RID: 126979 RVA: 0x002E189B File Offset: 0x002DFA9B
		public virtual void UpdateBP(float DeltaTime)
		{
			ULGUIBehaviour.__UpdateBP_Internal(base.NativePtr, DeltaTime);
		}

		// Token: 0x0601F004 RID: 126980 RVA: 0x002E18A9 File Offset: 0x002DFAA9
		public virtual void StartBP()
		{
			ULGUIBehaviour.__StartBP_Internal(base.NativePtr);
		}

		// Token: 0x0601F005 RID: 126981 RVA: 0x002E18B6 File Offset: 0x002DFAB6
		public void SetEnable(bool value)
		{
			ULGUIBehaviour.__SetEnable_Internal(base.NativePtr, value);
		}

		// Token: 0x0601F006 RID: 126982 RVA: 0x002E18C4 File Offset: 0x002DFAC4
		public virtual void OnUIInteractionStateChangedBP(bool interactableOrNot)
		{
			ULGUIBehaviour.__OnUIInteractionStateChangedBP_Internal(base.NativePtr, interactableOrNot);
		}

		// Token: 0x0601F007 RID: 126983 RVA: 0x002E18D2 File Offset: 0x002DFAD2
		public virtual void OnUIDimensionsChangedBP(bool positionChanged, bool sizeChanged)
		{
			ULGUIBehaviour.__OnUIDimensionsChangedBP_Internal(base.NativePtr, positionChanged, sizeChanged);
		}

		// Token: 0x0601F008 RID: 126984 RVA: 0x002E18E1 File Offset: 0x002DFAE1
		[NullableContext(2)]
		public virtual void OnUIChildHierarchyIndexChangedBP(UUIItem child)
		{
			ULGUIBehaviour.__OnUIChildHierarchyIndexChangedBP_Internal(base.NativePtr, (child != null) ? child.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0601F009 RID: 126985 RVA: 0x002E18FE File Offset: 0x002DFAFE
		[NullableContext(2)]
		public virtual void OnUIChildAttachmentChangedBP(UUIItem child, bool attachOrDetach)
		{
			ULGUIBehaviour.__OnUIChildAttachmentChangedBP_Internal(base.NativePtr, (child != null) ? child.NativePtr : IntPtr.Zero, attachOrDetach);
		}

		// Token: 0x0601F00A RID: 126986 RVA: 0x002E191C File Offset: 0x002DFB1C
		[NullableContext(2)]
		public virtual void OnUIChildAcitveInHierarchyBP(UUIItem child, bool ativeOrInactive)
		{
			ULGUIBehaviour.__OnUIChildAcitveInHierarchyBP_Internal(base.NativePtr, (child != null) ? child.NativePtr : IntPtr.Zero, ativeOrInactive);
		}

		// Token: 0x0601F00B RID: 126987 RVA: 0x002E193A File Offset: 0x002DFB3A
		public virtual void OnUIAttachmentChangedBP()
		{
			ULGUIBehaviour.__OnUIAttachmentChangedBP_Internal(base.NativePtr);
		}

		// Token: 0x0601F00C RID: 126988 RVA: 0x002E1947 File Offset: 0x002DFB47
		public virtual void OnUIActiveInHierarchyBP(bool activeOrInactive)
		{
			ULGUIBehaviour.__OnUIActiveInHierarchyBP_Internal(base.NativePtr, activeOrInactive);
		}

		// Token: 0x0601F00D RID: 126989 RVA: 0x002E1955 File Offset: 0x002DFB55
		public virtual void OnPreDestroyBP()
		{
			ULGUIBehaviour.__OnPreDestroyBP_Internal(base.NativePtr);
		}

		// Token: 0x0601F00E RID: 126990 RVA: 0x002E1962 File Offset: 0x002DFB62
		public virtual void OnEnableBP()
		{
			ULGUIBehaviour.__OnEnableBP_Internal(base.NativePtr);
		}

		// Token: 0x0601F00F RID: 126991 RVA: 0x002E196F File Offset: 0x002DFB6F
		public virtual void OnDisableBP()
		{
			ULGUIBehaviour.__OnDisableBP_Internal(base.NativePtr);
		}

		// Token: 0x0601F010 RID: 126992 RVA: 0x002E197C File Offset: 0x002DFB7C
		public virtual void OnDestroyBP()
		{
			ULGUIBehaviour.__OnDestroyBP_Internal(base.NativePtr);
		}

		// Token: 0x0601F011 RID: 126993 RVA: 0x002E1989 File Offset: 0x002DFB89
		public virtual void LateUpdateBP(float DeltaTime)
		{
			ULGUIBehaviour.__LateUpdateBP_Internal(base.NativePtr, DeltaTime);
		}

		// Token: 0x0601F012 RID: 126994 RVA: 0x002E1997 File Offset: 0x002DFB97
		[NullableContext(2)]
		public AActor InstantiatePrefabWithTransform(ULGUIPrefab OriginObject, USceneComponent Parent, FVector Location, FRotator Rotation, FVector Scale)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(ULGUIBehaviour.__InstantiatePrefabWithTransform_Internal(base.NativePtr, (OriginObject != null) ? OriginObject.NativePtr : IntPtr.Zero, (Parent != null) ? Parent.NativePtr : IntPtr.Zero, Location, Rotation, Scale));
		}

		// Token: 0x0601F013 RID: 126995 RVA: 0x002E19CE File Offset: 0x002DFBCE
		[NullableContext(2)]
		public AActor InstantiatePrefab(ULGUIPrefab OriginObject, USceneComponent Parent)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(ULGUIBehaviour.__InstantiatePrefab_Internal(base.NativePtr, (OriginObject != null) ? OriginObject.NativePtr : IntPtr.Zero, (Parent != null) ? Parent.NativePtr : IntPtr.Zero));
		}

		// Token: 0x0601F014 RID: 126996 RVA: 0x002E1A00 File Offset: 0x002DFC00
		[NullableContext(2)]
		public AActor InstantiateActor(AActor OriginObject, USceneComponent Parent)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(ULGUIBehaviour.__InstantiateActor_Internal(base.NativePtr, (OriginObject != null) ? OriginObject.NativePtr : IntPtr.Zero, (Parent != null) ? Parent.NativePtr : IntPtr.Zero));
		}

		// Token: 0x0601F015 RID: 126997 RVA: 0x002E1A32 File Offset: 0x002DFC32
		[NullableContext(2)]
		public USceneComponent GetRootSceneComponent()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<USceneComponent>(ULGUIBehaviour.__GetRootSceneComponent_Internal(base.NativePtr));
		}

		// Token: 0x0601F016 RID: 126998 RVA: 0x002E1A44 File Offset: 0x002DFC44
		[NullableContext(2)]
		public UUIItem GetRootComponent()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UUIItem>(ULGUIBehaviour.__GetRootComponent_Internal(base.NativePtr));
		}

		// Token: 0x0601F017 RID: 126999 RVA: 0x002E1A56 File Offset: 0x002DFC56
		public bool GetIsActiveAndEnable()
		{
			return ULGUIBehaviour.__GetIsActiveAndEnable_Internal(base.NativePtr);
		}

		// Token: 0x0601F018 RID: 127000 RVA: 0x002E1A63 File Offset: 0x002DFC63
		public bool GetEnable()
		{
			return ULGUIBehaviour.__GetEnable_Internal(base.NativePtr);
		}

		// Token: 0x0601F019 RID: 127001 RVA: 0x002E1A70 File Offset: 0x002DFC70
		public bool CheckRootUIComponent()
		{
			return ULGUIBehaviour.__CheckRootUIComponent_Internal(base.NativePtr);
		}

		// Token: 0x0601F01A RID: 127002 RVA: 0x002E1A7D File Offset: 0x002DFC7D
		public virtual void AwakeBP()
		{
			ULGUIBehaviour.__AwakeBP_Internal(base.NativePtr);
		}

		// Token: 0x0601F01B RID: 127003
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UpdateBP_Internal(IntPtr @this, float DeltaTime);

		// Token: 0x0601F01C RID: 127004
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __StartBP_Internal(IntPtr @this);

		// Token: 0x0601F01D RID: 127005
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetEnable_Internal(IntPtr @this, bool value);

		// Token: 0x0601F01E RID: 127006
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnUIInteractionStateChangedBP_Internal(IntPtr @this, bool interactableOrNot);

		// Token: 0x0601F01F RID: 127007
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnUIDimensionsChangedBP_Internal(IntPtr @this, bool positionChanged, bool sizeChanged);

		// Token: 0x0601F020 RID: 127008
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnUIChildHierarchyIndexChangedBP_Internal(IntPtr @this, IntPtr child);

		// Token: 0x0601F021 RID: 127009
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnUIChildAttachmentChangedBP_Internal(IntPtr @this, IntPtr child, bool attachOrDetach);

		// Token: 0x0601F022 RID: 127010
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnUIChildAcitveInHierarchyBP_Internal(IntPtr @this, IntPtr child, bool ativeOrInactive);

		// Token: 0x0601F023 RID: 127011
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnUIAttachmentChangedBP_Internal(IntPtr @this);

		// Token: 0x0601F024 RID: 127012
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnUIActiveInHierarchyBP_Internal(IntPtr @this, bool activeOrInactive);

		// Token: 0x0601F025 RID: 127013
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnPreDestroyBP_Internal(IntPtr @this);

		// Token: 0x0601F026 RID: 127014
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnEnableBP_Internal(IntPtr @this);

		// Token: 0x0601F027 RID: 127015
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnDisableBP_Internal(IntPtr @this);

		// Token: 0x0601F028 RID: 127016
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnDestroyBP_Internal(IntPtr @this);

		// Token: 0x0601F029 RID: 127017
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __LateUpdateBP_Internal(IntPtr @this, float DeltaTime);

		// Token: 0x0601F02A RID: 127018
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __InstantiatePrefabWithTransform_Internal(IntPtr @this, IntPtr OriginObject, IntPtr Parent, FVector Location, FRotator Rotation, FVector Scale);

		// Token: 0x0601F02B RID: 127019
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __InstantiatePrefab_Internal(IntPtr @this, IntPtr OriginObject, IntPtr Parent);

		// Token: 0x0601F02C RID: 127020
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __InstantiateActor_Internal(IntPtr @this, IntPtr OriginObject, IntPtr Parent);

		// Token: 0x0601F02D RID: 127021
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetRootSceneComponent_Internal(IntPtr @this);

		// Token: 0x0601F02E RID: 127022
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetRootComponent_Internal(IntPtr @this);

		// Token: 0x0601F02F RID: 127023
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetIsActiveAndEnable_Internal(IntPtr @this);

		// Token: 0x0601F030 RID: 127024
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetEnable_Internal(IntPtr @this);

		// Token: 0x0601F031 RID: 127025
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __CheckRootUIComponent_Internal(IntPtr @this);

		// Token: 0x0601F032 RID: 127026
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AwakeBP_Internal(IntPtr @this);

		// Token: 0x0601F033 RID: 127027 RVA: 0x002E1A8A File Offset: 0x002DFC8A
		static ULGUIBehaviour()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.LGUIBehaviour");
		}

		// Token: 0x0601F034 RID: 127028 RVA: 0x002E1A98 File Offset: 0x002DFC98
		protected ULGUIBehaviour() : this(BuiltinUtils.AllocNativeUObject(ULGUIBehaviour.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601F035 RID: 127029 RVA: 0x002E1AC0 File Offset: 0x002DFCC0
		protected ULGUIBehaviour(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04010D97 RID: 69015
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LGUI.LGUIBehaviour";

		// Token: 0x04010D98 RID: 69016
		private static IntPtr _ClassPtr;

		// Token: 0x04010D99 RID: 69017
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04010D9A RID: 69018
		internal static int __PropertyOffset_enable;

		// Token: 0x04010D9B RID: 69019
		internal static int __PropertyOffset_OnLateUpdate;

		// Token: 0x04010D9C RID: 69020
		[Nullable(2)]
		private FLGUIBehaviourLateUpdateDelegate _OnLateUpdate;

		// Token: 0x04010D9D RID: 69021
		internal static int __PropertyOffset_RootUIComp;

		// Token: 0x0200342B RID: 13355
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __UpdateBP_FunctionParams
		{
			// Token: 0x04017407 RID: 95239
			[FieldOffset(0)]
			public float DeltaTime;
		}

		// Token: 0x0200342C RID: 13356
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __OnUIInteractionStateChangedBP_FunctionParams
		{
			// Token: 0x04017408 RID: 95240
			[FieldOffset(0)]
			public bool interactableOrNot;
		}

		// Token: 0x0200342D RID: 13357
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 2)]
		protected ref struct __OnUIDimensionsChangedBP_FunctionParams
		{
			// Token: 0x04017409 RID: 95241
			[FieldOffset(0)]
			public bool positionChanged;

			// Token: 0x0401740A RID: 95242
			[FieldOffset(1)]
			public bool sizeChanged;
		}

		// Token: 0x0200342E RID: 13358
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __OnUIChildHierarchyIndexChangedBP_FunctionParams
		{
			// Token: 0x0401740B RID: 95243
			[FieldOffset(0)]
			public IntPtr child;
		}

		// Token: 0x0200342F RID: 13359
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __OnUIChildAttachmentChangedBP_FunctionParams
		{
			// Token: 0x0401740C RID: 95244
			[FieldOffset(0)]
			public IntPtr child;

			// Token: 0x0401740D RID: 95245
			[FieldOffset(8)]
			public bool attachOrDetach;
		}

		// Token: 0x02003430 RID: 13360
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __OnUIChildAcitveInHierarchyBP_FunctionParams
		{
			// Token: 0x0401740E RID: 95246
			[FieldOffset(0)]
			public IntPtr child;

			// Token: 0x0401740F RID: 95247
			[FieldOffset(8)]
			public bool ativeOrInactive;
		}

		// Token: 0x02003431 RID: 13361
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __OnUIActiveInHierarchyBP_FunctionParams
		{
			// Token: 0x04017410 RID: 95248
			[FieldOffset(0)]
			public bool activeOrInactive;
		}

		// Token: 0x02003432 RID: 13362
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __LateUpdateBP_FunctionParams
		{
			// Token: 0x04017411 RID: 95249
			[FieldOffset(0)]
			public float DeltaTime;
		}
	}
}
