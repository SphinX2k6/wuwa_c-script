using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020000AE RID: 174
	[UnrealObjectPath("/Script/AIModule.BTAuxiliaryNode")]
	[UnrealStructLayout(120, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 120)]
	public abstract class UBTAuxiliaryNode : UBTNode, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06000D31 RID: 3377 RVA: 0x00014E5D File Offset: 0x0001305D
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UBTAuxiliaryNode._ClassPtr;
		}

		// Token: 0x06000D32 RID: 3378 RVA: 0x00014E69 File Offset: 0x00013069
		static UBTAuxiliaryNode()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AIModule.BTAuxiliaryNode");
		}

		// Token: 0x06000D33 RID: 3379 RVA: 0x00014E78 File Offset: 0x00013078
		protected UBTAuxiliaryNode() : this(BuiltinUtils.AllocNativeUObject(UBTAuxiliaryNode.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06000D34 RID: 3380 RVA: 0x00014EA0 File Offset: 0x000130A0
		protected UBTAuxiliaryNode(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04000246 RID: 582
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AIModule.BTAuxiliaryNode";

		// Token: 0x04000247 RID: 583
		private static IntPtr _ClassPtr;

		// Token: 0x04000248 RID: 584
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
