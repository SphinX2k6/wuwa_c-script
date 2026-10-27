using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000132 RID: 306
	[UnrealObjectPath("/Script/AIModule.BTAuxiliaryNode")]
	[UnrealStructLayout(120, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 120)]
	public abstract class UBTAuxiliaryNode : UBTNode, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060015BF RID: 5567 RVA: 0x0001FF01 File Offset: 0x0001E101
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UBTAuxiliaryNode._ClassPtr;
		}

		// Token: 0x060015C0 RID: 5568 RVA: 0x0001FF0D File Offset: 0x0001E10D
		static UBTAuxiliaryNode()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AIModule.BTAuxiliaryNode");
		}

		// Token: 0x060015C1 RID: 5569 RVA: 0x0001FF1C File Offset: 0x0001E11C
		protected UBTAuxiliaryNode() : this(BuiltinUtils.AllocNativeUObject(UBTAuxiliaryNode.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060015C2 RID: 5570 RVA: 0x0001FF44 File Offset: 0x0001E144
		protected UBTAuxiliaryNode(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040004B3 RID: 1203
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AIModule.BTAuxiliaryNode";

		// Token: 0x040004B4 RID: 1204
		private static IntPtr _ClassPtr;

		// Token: 0x040004B5 RID: 1205
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
