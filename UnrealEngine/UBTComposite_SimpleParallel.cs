using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000137 RID: 311
	[UnrealObjectPath("/Script/AIModule.BTComposite_SimpleParallel")]
	[UnrealStructLayout(176, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 176)]
	public class UBTComposite_SimpleParallel : UBTCompositeNode, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060015E9 RID: 5609 RVA: 0x0002033A File Offset: 0x0001E53A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UBTComposite_SimpleParallel._ClassPtr;
		}

		// Token: 0x060015EA RID: 5610 RVA: 0x00020348 File Offset: 0x0001E548
		public UBTComposite_SimpleParallel() : this(BuiltinUtils.AllocNativeUObject(UBTComposite_SimpleParallel.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060015EB RID: 5611 RVA: 0x00020370 File Offset: 0x0001E570
		[NullableContext(1)]
		public UBTComposite_SimpleParallel(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UBTComposite_SimpleParallel.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170005BB RID: 1467
		// (get) Token: 0x060015EC RID: 5612 RVA: 0x000203A3 File Offset: 0x0001E5A3
		// (set) Token: 0x060015ED RID: 5613 RVA: 0x000203B7 File Offset: 0x0001E5B7
		public unsafe TEnumAsByte<EBTParallelMode> FinishMode
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UBTComposite_SimpleParallel.__PropertyOffset_FinishMode);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UBTComposite_SimpleParallel.__PropertyOffset_FinishMode) = value;
			}
		}

		// Token: 0x060015EE RID: 5614 RVA: 0x000203CC File Offset: 0x0001E5CC
		static UBTComposite_SimpleParallel()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AIModule.BTComposite_SimpleParallel");
		}

		// Token: 0x060015EF RID: 5615 RVA: 0x000203DA File Offset: 0x0001E5DA
		protected UBTComposite_SimpleParallel(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040004CF RID: 1231
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AIModule.BTComposite_SimpleParallel";

		// Token: 0x040004D0 RID: 1232
		private static IntPtr _ClassPtr;

		// Token: 0x040004D1 RID: 1233
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040004D2 RID: 1234
		internal static int __PropertyOffset_FinishMode;
	}
}
