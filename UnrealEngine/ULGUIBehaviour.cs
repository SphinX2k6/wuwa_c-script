using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200066A RID: 1642
	[UnrealObjectPath("/Script/LGUI.LGUIBehaviour")]
	[UnrealStructLayout(272, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 272)]
	public abstract class ULGUIBehaviour : UActorComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06008E08 RID: 36360 RVA: 0x000D5E05 File Offset: 0x000D4005
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ULGUIBehaviour._ClassPtr;
		}

		// Token: 0x17001AE5 RID: 6885
		// (get) Token: 0x06008E09 RID: 36361 RVA: 0x000D5E11 File Offset: 0x000D4011
		// (set) Token: 0x06008E0A RID: 36362 RVA: 0x000D5E21 File Offset: 0x000D4021
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

		// Token: 0x17001AE6 RID: 6886
		// (get) Token: 0x06008E0B RID: 36363 RVA: 0x000D5E34 File Offset: 0x000D4034
		// (set) Token: 0x06008E0C RID: 36364 RVA: 0x000D5E6D File Offset: 0x000D406D
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

		// Token: 0x17001AE7 RID: 6887
		// (get) Token: 0x06008E0D RID: 36365 RVA: 0x000D5E8E File Offset: 0x000D408E
		// (set) Token: 0x06008E0E RID: 36366 RVA: 0x000D5EA2 File Offset: 0x000D40A2
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

		// Token: 0x06008E0F RID: 36367 RVA: 0x000D5EB7 File Offset: 0x000D40B7
		public virtual void UpdateBP(float DeltaTime)
		{
			ULGUIBehaviour.__UpdateBP_Internal(base.NativePtr, DeltaTime);
		}

		// Token: 0x06008E10 RID: 36368 RVA: 0x000D5EC5 File Offset: 0x000D40C5
		public virtual void StartBP()
		{
			ULGUIBehaviour.__StartBP_Internal(base.NativePtr);
		}

		// Token: 0x06008E11 RID: 36369 RVA: 0x000D5ED2 File Offset: 0x000D40D2
		public void SetEnable(bool value)
		{
			ULGUIBehaviour.__SetEnable_Internal(base.NativePtr, value);
		}

		// Token: 0x06008E12 RID: 36370 RVA: 0x000D5EE0 File Offset: 0x000D40E0
		public virtual void OnUIInteractionStateChangedBP(bool interactableOrNot)
		{
			ULGUIBehaviour.__OnUIInteractionStateChangedBP_Internal(base.NativePtr, interactableOrNot);
		}

		// Token: 0x06008E13 RID: 36371 RVA: 0x000D5EEE File Offset: 0x000D40EE
		public virtual void OnUIDimensionsChangedBP(bool positionChanged, bool sizeChanged)
		{
			ULGUIBehaviour.__OnUIDimensionsChangedBP_Internal(base.NativePtr, positionChanged, sizeChanged);
		}

		// Token: 0x06008E14 RID: 36372 RVA: 0x000D5EFD File Offset: 0x000D40FD
		[NullableContext(2)]
		public virtual void OnUIChildHierarchyIndexChangedBP(UUIItem child)
		{
			ULGUIBehaviour.__OnUIChildHierarchyIndexChangedBP_Internal(base.NativePtr, (child != null) ? child.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06008E15 RID: 36373 RVA: 0x000D5F1A File Offset: 0x000D411A
		[NullableContext(2)]
		public virtual void OnUIChildAttachmentChangedBP(UUIItem child, bool attachOrDetach)
		{
			ULGUIBehaviour.__OnUIChildAttachmentChangedBP_Internal(base.NativePtr, (child != null) ? child.NativePtr : IntPtr.Zero, attachOrDetach);
		}

		// Token: 0x06008E16 RID: 36374 RVA: 0x000D5F38 File Offset: 0x000D4138
		[NullableContext(2)]
		public virtual void OnUIChildAcitveInHierarchyBP(UUIItem child, bool ativeOrInactive)
		{
			ULGUIBehaviour.__OnUIChildAcitveInHierarchyBP_Internal(base.NativePtr, (child != null) ? child.NativePtr : IntPtr.Zero, ativeOrInactive);
		}

		// Token: 0x06008E17 RID: 36375 RVA: 0x000D5F56 File Offset: 0x000D4156
		public virtual void OnUIAttachmentChangedBP()
		{
			ULGUIBehaviour.__OnUIAttachmentChangedBP_Internal(base.NativePtr);
		}

		// Token: 0x06008E18 RID: 36376 RVA: 0x000D5F63 File Offset: 0x000D4163
		public virtual void OnUIActiveInHierarchyBP(bool activeOrInactive)
		{
			ULGUIBehaviour.__OnUIActiveInHierarchyBP_Internal(base.NativePtr, activeOrInactive);
		}

		// Token: 0x06008E19 RID: 36377 RVA: 0x000D5F71 File Offset: 0x000D4171
		public virtual void OnPreDestroyBP()
		{
			ULGUIBehaviour.__OnPreDestroyBP_Internal(base.NativePtr);
		}

		// Token: 0x06008E1A RID: 36378 RVA: 0x000D5F7E File Offset: 0x000D417E
		public virtual void OnEnableBP()
		{
			ULGUIBehaviour.__OnEnableBP_Internal(base.NativePtr);
		}

		// Token: 0x06008E1B RID: 36379 RVA: 0x000D5F8B File Offset: 0x000D418B
		public virtual void OnDisableBP()
		{
			ULGUIBehaviour.__OnDisableBP_Internal(base.NativePtr);
		}

		// Token: 0x06008E1C RID: 36380 RVA: 0x000D5F98 File Offset: 0x000D4198
		public virtual void OnDestroyBP()
		{
			ULGUIBehaviour.__OnDestroyBP_Internal(base.NativePtr);
		}

		// Token: 0x06008E1D RID: 36381 RVA: 0x000D5FA5 File Offset: 0x000D41A5
		public virtual void LateUpdateBP(float DeltaTime)
		{
			ULGUIBehaviour.__LateUpdateBP_Internal(base.NativePtr, DeltaTime);
		}

		// Token: 0x06008E1E RID: 36382 RVA: 0x000D5FB3 File Offset: 0x000D41B3
		[NullableContext(2)]
		public AActor InstantiatePrefabWithTransform(ULGUIPrefab OriginObject, USceneComponent Parent, FVector Location, FRotator Rotation, FVector Scale)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(ULGUIBehaviour.__InstantiatePrefabWithTransform_Internal(base.NativePtr, (OriginObject != null) ? OriginObject.NativePtr : IntPtr.Zero, (Parent != null) ? Parent.NativePtr : IntPtr.Zero, Location, Rotation, Scale));
		}

		// Token: 0x06008E1F RID: 36383 RVA: 0x000D5FEA File Offset: 0x000D41EA
		[NullableContext(2)]
		public AActor InstantiatePrefab(ULGUIPrefab OriginObject, USceneComponent Parent)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(ULGUIBehaviour.__InstantiatePrefab_Internal(base.NativePtr, (OriginObject != null) ? OriginObject.NativePtr : IntPtr.Zero, (Parent != null) ? Parent.NativePtr : IntPtr.Zero));
		}

		// Token: 0x06008E20 RID: 36384 RVA: 0x000D601C File Offset: 0x000D421C
		[NullableContext(2)]
		public AActor InstantiateActor(AActor OriginObject, USceneComponent Parent)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<AActor>(ULGUIBehaviour.__InstantiateActor_Internal(base.NativePtr, (OriginObject != null) ? OriginObject.NativePtr : IntPtr.Zero, (Parent != null) ? Parent.NativePtr : IntPtr.Zero));
		}

		// Token: 0x06008E21 RID: 36385 RVA: 0x000D604E File Offset: 0x000D424E
		[NullableContext(2)]
		public USceneComponent GetRootSceneComponent()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<USceneComponent>(ULGUIBehaviour.__GetRootSceneComponent_Internal(base.NativePtr));
		}

		// Token: 0x06008E22 RID: 36386 RVA: 0x000D6060 File Offset: 0x000D4260
		[NullableContext(2)]
		public UUIItem GetRootComponent()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UUIItem>(ULGUIBehaviour.__GetRootComponent_Internal(base.NativePtr));
		}

		// Token: 0x06008E23 RID: 36387 RVA: 0x000D6072 File Offset: 0x000D4272
		public bool GetIsActiveAndEnable()
		{
			return ULGUIBehaviour.__GetIsActiveAndEnable_Internal(base.NativePtr);
		}

		// Token: 0x06008E24 RID: 36388 RVA: 0x000D607F File Offset: 0x000D427F
		public bool GetEnable()
		{
			return ULGUIBehaviour.__GetEnable_Internal(base.NativePtr);
		}

		// Token: 0x06008E25 RID: 36389 RVA: 0x000D608C File Offset: 0x000D428C
		public bool CheckRootUIComponent()
		{
			return ULGUIBehaviour.__CheckRootUIComponent_Internal(base.NativePtr);
		}

		// Token: 0x06008E26 RID: 36390 RVA: 0x000D6099 File Offset: 0x000D4299
		public virtual void AwakeBP()
		{
			ULGUIBehaviour.__AwakeBP_Internal(base.NativePtr);
		}

		// Token: 0x06008E27 RID: 36391
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UpdateBP_Internal(IntPtr @this, float DeltaTime);

		// Token: 0x06008E28 RID: 36392
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __StartBP_Internal(IntPtr @this);

		// Token: 0x06008E29 RID: 36393
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetEnable_Internal(IntPtr @this, bool value);

		// Token: 0x06008E2A RID: 36394
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnUIInteractionStateChangedBP_Internal(IntPtr @this, bool interactableOrNot);

		// Token: 0x06008E2B RID: 36395
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnUIDimensionsChangedBP_Internal(IntPtr @this, bool positionChanged, bool sizeChanged);

		// Token: 0x06008E2C RID: 36396
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnUIChildHierarchyIndexChangedBP_Internal(IntPtr @this, IntPtr child);

		// Token: 0x06008E2D RID: 36397
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnUIChildAttachmentChangedBP_Internal(IntPtr @this, IntPtr child, bool attachOrDetach);

		// Token: 0x06008E2E RID: 36398
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnUIChildAcitveInHierarchyBP_Internal(IntPtr @this, IntPtr child, bool ativeOrInactive);

		// Token: 0x06008E2F RID: 36399
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnUIAttachmentChangedBP_Internal(IntPtr @this);

		// Token: 0x06008E30 RID: 36400
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnUIActiveInHierarchyBP_Internal(IntPtr @this, bool activeOrInactive);

		// Token: 0x06008E31 RID: 36401
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnPreDestroyBP_Internal(IntPtr @this);

		// Token: 0x06008E32 RID: 36402
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnEnableBP_Internal(IntPtr @this);

		// Token: 0x06008E33 RID: 36403
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnDisableBP_Internal(IntPtr @this);

		// Token: 0x06008E34 RID: 36404
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnDestroyBP_Internal(IntPtr @this);

		// Token: 0x06008E35 RID: 36405
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __LateUpdateBP_Internal(IntPtr @this, float DeltaTime);

		// Token: 0x06008E36 RID: 36406
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __InstantiatePrefabWithTransform_Internal(IntPtr @this, IntPtr OriginObject, IntPtr Parent, FVector Location, FRotator Rotation, FVector Scale);

		// Token: 0x06008E37 RID: 36407
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __InstantiatePrefab_Internal(IntPtr @this, IntPtr OriginObject, IntPtr Parent);

		// Token: 0x06008E38 RID: 36408
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __InstantiateActor_Internal(IntPtr @this, IntPtr OriginObject, IntPtr Parent);

		// Token: 0x06008E39 RID: 36409
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetRootSceneComponent_Internal(IntPtr @this);

		// Token: 0x06008E3A RID: 36410
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetRootComponent_Internal(IntPtr @this);

		// Token: 0x06008E3B RID: 36411
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetIsActiveAndEnable_Internal(IntPtr @this);

		// Token: 0x06008E3C RID: 36412
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetEnable_Internal(IntPtr @this);

		// Token: 0x06008E3D RID: 36413
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __CheckRootUIComponent_Internal(IntPtr @this);

		// Token: 0x06008E3E RID: 36414
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AwakeBP_Internal(IntPtr @this);

		// Token: 0x06008E3F RID: 36415 RVA: 0x000D60A6 File Offset: 0x000D42A6
		static ULGUIBehaviour()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.LGUIBehaviour");
		}

		// Token: 0x06008E40 RID: 36416 RVA: 0x000D60B4 File Offset: 0x000D42B4
		protected ULGUIBehaviour() : this(BuiltinUtils.AllocNativeUObject(ULGUIBehaviour.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06008E41 RID: 36417 RVA: 0x000D60DC File Offset: 0x000D42DC
		protected ULGUIBehaviour(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04003E98 RID: 16024
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LGUI.LGUIBehaviour";

		// Token: 0x04003E99 RID: 16025
		private static IntPtr _ClassPtr;

		// Token: 0x04003E9A RID: 16026
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04003E9B RID: 16027
		internal static int __PropertyOffset_enable;

		// Token: 0x04003E9C RID: 16028
		internal static int __PropertyOffset_OnLateUpdate;

		// Token: 0x04003E9D RID: 16029
		[Nullable(2)]
		private FLGUIBehaviourLateUpdateDelegate _OnLateUpdate;

		// Token: 0x04003E9E RID: 16030
		internal static int __PropertyOffset_RootUIComp;

		// Token: 0x02000E6E RID: 3694
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __UpdateBP_FunctionParams
		{
			// Token: 0x04006216 RID: 25110
			[FieldOffset(0)]
			public float DeltaTime;
		}

		// Token: 0x02000E6F RID: 3695
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __OnUIInteractionStateChangedBP_FunctionParams
		{
			// Token: 0x04006217 RID: 25111
			[FieldOffset(0)]
			public bool interactableOrNot;
		}

		// Token: 0x02000E70 RID: 3696
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 2)]
		protected ref struct __OnUIDimensionsChangedBP_FunctionParams
		{
			// Token: 0x04006218 RID: 25112
			[FieldOffset(0)]
			public bool positionChanged;

			// Token: 0x04006219 RID: 25113
			[FieldOffset(1)]
			public bool sizeChanged;
		}

		// Token: 0x02000E71 RID: 3697
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __OnUIChildHierarchyIndexChangedBP_FunctionParams
		{
			// Token: 0x0400621A RID: 25114
			[FieldOffset(0)]
			public IntPtr child;
		}

		// Token: 0x02000E72 RID: 3698
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __OnUIChildAttachmentChangedBP_FunctionParams
		{
			// Token: 0x0400621B RID: 25115
			[FieldOffset(0)]
			public IntPtr child;

			// Token: 0x0400621C RID: 25116
			[FieldOffset(8)]
			public bool attachOrDetach;
		}

		// Token: 0x02000E73 RID: 3699
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __OnUIChildAcitveInHierarchyBP_FunctionParams
		{
			// Token: 0x0400621D RID: 25117
			[FieldOffset(0)]
			public IntPtr child;

			// Token: 0x0400621E RID: 25118
			[FieldOffset(8)]
			public bool ativeOrInactive;
		}

		// Token: 0x02000E74 RID: 3700
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __OnUIActiveInHierarchyBP_FunctionParams
		{
			// Token: 0x0400621F RID: 25119
			[FieldOffset(0)]
			public bool activeOrInactive;
		}

		// Token: 0x02000E75 RID: 3701
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __LateUpdateBP_FunctionParams
		{
			// Token: 0x04006220 RID: 25120
			[FieldOffset(0)]
			public float DeltaTime;
		}
	}
}
