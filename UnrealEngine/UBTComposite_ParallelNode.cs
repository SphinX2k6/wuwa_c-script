using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020015F3 RID: 5619
	[UnrealObjectPath("/Script/KuroAI.BTComposite_ParallelNode")]
	[UnrealStructLayout(176, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 176)]
	public class UBTComposite_ParallelNode : UBTCompositeNode, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060143D2 RID: 82898 RVA: 0x001DB7BE File Offset: 0x001D99BE
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UBTComposite_ParallelNode._ClassPtr;
		}

		// Token: 0x060143D3 RID: 82899 RVA: 0x001DB7CC File Offset: 0x001D99CC
		public UBTComposite_ParallelNode() : this(BuiltinUtils.AllocNativeUObject(UBTComposite_ParallelNode.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060143D4 RID: 82900 RVA: 0x001DB7F4 File Offset: 0x001D99F4
		[NullableContext(1)]
		public UBTComposite_ParallelNode(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UBTComposite_ParallelNode.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17004F4F RID: 20303
		// (get) Token: 0x060143D5 RID: 82901 RVA: 0x001DB827 File Offset: 0x001D9A27
		// (set) Token: 0x060143D6 RID: 82902 RVA: 0x001DB837 File Offset: 0x001D9A37
		public unsafe bool Test
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UBTComposite_ParallelNode.__PropertyOffset_Test) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UBTComposite_ParallelNode.__PropertyOffset_Test) = (value ? 1 : 0);
			}
		}

		// Token: 0x060143D7 RID: 82903 RVA: 0x001DB848 File Offset: 0x001D9A48
		static UBTComposite_ParallelNode()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroAI.BTComposite_ParallelNode");
		}

		// Token: 0x060143D8 RID: 82904 RVA: 0x001DB856 File Offset: 0x001D9A56
		protected UBTComposite_ParallelNode(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400B029 RID: 45097
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroAI.BTComposite_ParallelNode";

		// Token: 0x0400B02A RID: 45098
		private static IntPtr _ClassPtr;

		// Token: 0x0400B02B RID: 45099
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400B02C RID: 45100
		internal static int __PropertyOffset_Test;
	}
}
