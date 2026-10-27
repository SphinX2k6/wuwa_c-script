using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020024A3 RID: 9379
	[UnrealObjectPath("/Script/NavigationSystem.NavModifierComponent")]
	[UnrealStructLayout(352, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 352)]
	public class UNavModifierComponent : UNavRelevantComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060231A2 RID: 143778 RVA: 0x0033E92C File Offset: 0x0033CB2C
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UNavModifierComponent._ClassPtr;
		}

		// Token: 0x060231A3 RID: 143779 RVA: 0x0033E938 File Offset: 0x0033CB38
		public UNavModifierComponent() : this(BuiltinUtils.AllocNativeUObject(UNavModifierComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060231A4 RID: 143780 RVA: 0x0033E960 File Offset: 0x0033CB60
		[NullableContext(1)]
		public UNavModifierComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UNavModifierComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170086DF RID: 34527
		// (get) Token: 0x060231A5 RID: 143781 RVA: 0x0033E993 File Offset: 0x0033CB93
		// (set) Token: 0x060231A6 RID: 143782 RVA: 0x0033E9A7 File Offset: 0x0033CBA7
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public unsafe TSubclassOf<UNavArea> AreaClass
		{
			[return: Nullable(new byte[]
			{
				0,
				1
			})]
			get
			{
				return *(base.NativePtr + (IntPtr)UNavModifierComponent.__PropertyOffset_AreaClass);
			}
			[param: Nullable(new byte[]
			{
				0,
				1
			})]
			set
			{
				*(base.NativePtr + (IntPtr)UNavModifierComponent.__PropertyOffset_AreaClass) = value;
			}
		}

		// Token: 0x170086E0 RID: 34528
		// (get) Token: 0x060231A7 RID: 143783 RVA: 0x0033E9BC File Offset: 0x0033CBBC
		// (set) Token: 0x060231A8 RID: 143784 RVA: 0x0033E9D0 File Offset: 0x0033CBD0
		public unsafe FVector FailsafeExtent
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNavModifierComponent.__PropertyOffset_FailsafeExtent);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNavModifierComponent.__PropertyOffset_FailsafeExtent) = value;
			}
		}

		// Token: 0x170086E1 RID: 34529
		// (get) Token: 0x060231A9 RID: 143785 RVA: 0x0033E9E5 File Offset: 0x0033CBE5
		// (set) Token: 0x060231AA RID: 143786 RVA: 0x0033E9FE File Offset: 0x0033CBFE
		public unsafe bool bIncludeAgentHeight
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UNavModifierComponent.__PropertyOffset_bIncludeAgentHeight) & UNavModifierComponent.__PropertyMask_bIncludeAgentHeight) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UNavModifierComponent.__PropertyOffset_bIncludeAgentHeight) = ((*(base.NativePtr + (IntPtr)UNavModifierComponent.__PropertyOffset_bIncludeAgentHeight) & ~UNavModifierComponent.__PropertyMask_bIncludeAgentHeight) | (value ? UNavModifierComponent.__PropertyMask_bIncludeAgentHeight : 0));
			}
		}

		// Token: 0x060231AB RID: 143787 RVA: 0x0033EA2E File Offset: 0x0033CC2E
		public void SetAreaClass([Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<UNavArea> NewAreaClass)
		{
			UNavModifierComponent.__SetAreaClass_Internal(base.NativePtr, NewAreaClass._NativePtr);
		}

		// Token: 0x060231AC RID: 143788
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetAreaClass_Internal(IntPtr @this, IntPtr NewAreaClass);

		// Token: 0x060231AD RID: 143789 RVA: 0x0033EA41 File Offset: 0x0033CC41
		static UNavModifierComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/NavigationSystem.NavModifierComponent");
		}

		// Token: 0x060231AE RID: 143790 RVA: 0x0033EA4F File Offset: 0x0033CC4F
		protected UNavModifierComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04012BD4 RID: 76756
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/NavigationSystem.NavModifierComponent";

		// Token: 0x04012BD5 RID: 76757
		private static IntPtr _ClassPtr;

		// Token: 0x04012BD6 RID: 76758
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04012BD7 RID: 76759
		internal static int __PropertyOffset_AreaClass;

		// Token: 0x04012BD8 RID: 76760
		internal static int __PropertyOffset_FailsafeExtent;

		// Token: 0x04012BD9 RID: 76761
		internal static int __PropertyOffset_bIncludeAgentHeight;

		// Token: 0x04012BDA RID: 76762
		internal static byte __PropertyMask_bIncludeAgentHeight;
	}
}
