using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020024A6 RID: 9382
	[UnrealObjectPath("/Script/NavigationSystem.NavRelevantComponent")]
	[UnrealStructLayout(248, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 248)]
	public class UNavRelevantComponent : UActorComponent, IUnrealUObject, IUnrealObject, INavRelevantInterface, IUnrealNativeInterface, IUnrealInterface
	{
		// Token: 0x060231BE RID: 143806 RVA: 0x0033EB5C File Offset: 0x0033CD5C
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UNavRelevantComponent._ClassPtr;
		}

		// Token: 0x060231BF RID: 143807 RVA: 0x0033EB68 File Offset: 0x0033CD68
		int INavRelevantInterface.InterfaceOffset()
		{
			return UNavRelevantComponent.__InterfaceOffset_INavRelevantInterface;
		}

		// Token: 0x060231C0 RID: 143808 RVA: 0x0033EB70 File Offset: 0x0033CD70
		public UNavRelevantComponent() : this(BuiltinUtils.AllocNativeUObject(UNavRelevantComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060231C1 RID: 143809 RVA: 0x0033EB98 File Offset: 0x0033CD98
		[NullableContext(1)]
		public UNavRelevantComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UNavRelevantComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170086E5 RID: 34533
		// (get) Token: 0x060231C2 RID: 143810 RVA: 0x0033EBCB File Offset: 0x0033CDCB
		// (set) Token: 0x060231C3 RID: 143811 RVA: 0x0033EBE4 File Offset: 0x0033CDE4
		public unsafe bool bAttachToOwnersRoot
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UNavRelevantComponent.__PropertyOffset_bAttachToOwnersRoot) & UNavRelevantComponent.__PropertyMask_bAttachToOwnersRoot) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UNavRelevantComponent.__PropertyOffset_bAttachToOwnersRoot) = ((*(base.NativePtr + (IntPtr)UNavRelevantComponent.__PropertyOffset_bAttachToOwnersRoot) & ~UNavRelevantComponent.__PropertyMask_bAttachToOwnersRoot) | (value ? UNavRelevantComponent.__PropertyMask_bAttachToOwnersRoot : 0));
			}
		}

		// Token: 0x170086E6 RID: 34534
		// (get) Token: 0x060231C4 RID: 143812 RVA: 0x0033EC14 File Offset: 0x0033CE14
		// (set) Token: 0x060231C5 RID: 143813 RVA: 0x0033EC28 File Offset: 0x0033CE28
		[Nullable(2)]
		public unsafe UObject CachedNavParent
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UObject>(base.NativePtr / (IntPtr)sizeof(void*) + UNavRelevantComponent.__PropertyOffset_CachedNavParent);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UNavRelevantComponent.__PropertyOffset_CachedNavParent, value);
			}
		}

		// Token: 0x060231C6 RID: 143814 RVA: 0x0033EC3D File Offset: 0x0033CE3D
		public void SetNavigationRelevancy(bool bRelevant)
		{
			UNavRelevantComponent.__SetNavigationRelevancy_Internal(base.NativePtr, bRelevant);
		}

		// Token: 0x060231C7 RID: 143815
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetNavigationRelevancy_Internal(IntPtr @this, bool bRelevant);

		// Token: 0x060231C8 RID: 143816 RVA: 0x0033EC4B File Offset: 0x0033CE4B
		static UNavRelevantComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/NavigationSystem.NavRelevantComponent");
		}

		// Token: 0x060231C9 RID: 143817 RVA: 0x0033EC59 File Offset: 0x0033CE59
		protected UNavRelevantComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04012BE3 RID: 76771
		internal static int __InterfaceOffset_INavRelevantInterface;

		// Token: 0x04012BE4 RID: 76772
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/NavigationSystem.NavRelevantComponent";

		// Token: 0x04012BE5 RID: 76773
		private static IntPtr _ClassPtr;

		// Token: 0x04012BE6 RID: 76774
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04012BE7 RID: 76775
		internal static int __PropertyOffset_bAttachToOwnersRoot;

		// Token: 0x04012BE8 RID: 76776
		internal static byte __PropertyMask_bAttachToOwnersRoot;

		// Token: 0x04012BE9 RID: 76777
		internal static int __PropertyOffset_CachedNavParent;
	}
}
