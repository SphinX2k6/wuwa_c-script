using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200028F RID: 655
	[UnrealObjectPath("/Script/Engine.StaticMeshActor")]
	[UnrealStructLayout(1056, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1056)]
	public class AStaticMeshActor : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600483F RID: 18495 RVA: 0x0006538E File Offset: 0x0006358E
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AStaticMeshActor._ClassPtr;
		}

		// Token: 0x06004840 RID: 18496 RVA: 0x0006539C File Offset: 0x0006359C
		public AStaticMeshActor() : this(BuiltinUtils.AllocNativeUObject(AStaticMeshActor.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06004841 RID: 18497 RVA: 0x000653C4 File Offset: 0x000635C4
		[NullableContext(1)]
		public AStaticMeshActor(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AStaticMeshActor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17000D6D RID: 3437
		// (get) Token: 0x06004842 RID: 18498 RVA: 0x000653F7 File Offset: 0x000635F7
		// (set) Token: 0x06004843 RID: 18499 RVA: 0x0006540B File Offset: 0x0006360B
		[Nullable(2)]
		public unsafe UStaticMeshComponent StaticMeshComponent
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UStaticMeshComponent>(base.NativePtr / (IntPtr)sizeof(void*) + AStaticMeshActor.__PropertyOffset_StaticMeshComponent);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AStaticMeshActor.__PropertyOffset_StaticMeshComponent, value);
			}
		}

		// Token: 0x17000D6E RID: 3438
		// (get) Token: 0x06004844 RID: 18500 RVA: 0x00065420 File Offset: 0x00063620
		// (set) Token: 0x06004845 RID: 18501 RVA: 0x00065430 File Offset: 0x00063630
		public unsafe bool bStaticMeshReplicateMovement
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AStaticMeshActor.__PropertyOffset_bStaticMeshReplicateMovement) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)AStaticMeshActor.__PropertyOffset_bStaticMeshReplicateMovement) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000D6F RID: 3439
		// (get) Token: 0x06004846 RID: 18502 RVA: 0x00065441 File Offset: 0x00063641
		// (set) Token: 0x06004847 RID: 18503 RVA: 0x0006545A File Offset: 0x0006365A
		public unsafe bool bHideLogicallyOnBeginPlay
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)AStaticMeshActor.__PropertyOffset_bHideLogicallyOnBeginPlay) & AStaticMeshActor.__PropertyMask_bHideLogicallyOnBeginPlay) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)AStaticMeshActor.__PropertyOffset_bHideLogicallyOnBeginPlay) = ((*(base.NativePtr + (IntPtr)AStaticMeshActor.__PropertyOffset_bHideLogicallyOnBeginPlay) & ~AStaticMeshActor.__PropertyMask_bHideLogicallyOnBeginPlay) | (value ? AStaticMeshActor.__PropertyMask_bHideLogicallyOnBeginPlay : 0));
			}
		}

		// Token: 0x06004848 RID: 18504 RVA: 0x0006548A File Offset: 0x0006368A
		public void SetMobility(EComponentMobility InMobility)
		{
			AStaticMeshActor.__SetMobility_Internal(base.NativePtr, InMobility);
		}

		// Token: 0x06004849 RID: 18505 RVA: 0x0006549D File Offset: 0x0006369D
		public void SetLogicallyShow(ECollisionEnabled Type)
		{
			AStaticMeshActor.__SetLogicallyShow_Internal(base.NativePtr, Type);
		}

		// Token: 0x0600484A RID: 18506 RVA: 0x000654B0 File Offset: 0x000636B0
		public void SetLogicallyHidden()
		{
			AStaticMeshActor.__SetLogicallyHidden_Internal(base.NativePtr);
		}

		// Token: 0x0600484B RID: 18507
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetMobility_Internal(IntPtr @this, TEnumAsByte<EComponentMobility> InMobility);

		// Token: 0x0600484C RID: 18508
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetLogicallyShow_Internal(IntPtr @this, TEnumAsByte<ECollisionEnabled> Type);

		// Token: 0x0600484D RID: 18509
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetLogicallyHidden_Internal(IntPtr @this);

		// Token: 0x0600484E RID: 18510 RVA: 0x000654BD File Offset: 0x000636BD
		static AStaticMeshActor()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.StaticMeshActor");
		}

		// Token: 0x0600484F RID: 18511 RVA: 0x000654CB File Offset: 0x000636CB
		protected AStaticMeshActor(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04001BEE RID: 7150
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.StaticMeshActor";

		// Token: 0x04001BEF RID: 7151
		private static IntPtr _ClassPtr;

		// Token: 0x04001BF0 RID: 7152
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04001BF1 RID: 7153
		internal static int __PropertyOffset_StaticMeshComponent;

		// Token: 0x04001BF2 RID: 7154
		internal static int __PropertyOffset_bStaticMeshReplicateMovement;

		// Token: 0x04001BF3 RID: 7155
		internal static int __PropertyOffset_bHideLogicallyOnBeginPlay;

		// Token: 0x04001BF4 RID: 7156
		internal static byte __PropertyMask_bHideLogicallyOnBeginPlay;
	}
}
