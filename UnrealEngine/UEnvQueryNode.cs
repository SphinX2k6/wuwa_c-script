using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020001A6 RID: 422
	[UnrealObjectPath("/Script/AIModule.EnvQueryNode")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 56)]
	public abstract class UEnvQueryNode : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060019E0 RID: 6624 RVA: 0x00026633 File Offset: 0x00024833
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UEnvQueryNode._ClassPtr;
		}

		// Token: 0x1700069E RID: 1694
		// (get) Token: 0x060019E1 RID: 6625 RVA: 0x0002663F File Offset: 0x0002483F
		// (set) Token: 0x060019E2 RID: 6626 RVA: 0x0002664F File Offset: 0x0002484F
		public unsafe int VerNum
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UEnvQueryNode.__PropertyOffset_VerNum);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UEnvQueryNode.__PropertyOffset_VerNum) = value;
			}
		}

		// Token: 0x060019E3 RID: 6627 RVA: 0x00026660 File Offset: 0x00024860
		static UEnvQueryNode()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AIModule.EnvQueryNode");
		}

		// Token: 0x060019E4 RID: 6628 RVA: 0x00026670 File Offset: 0x00024870
		protected UEnvQueryNode() : this(BuiltinUtils.AllocNativeUObject(UEnvQueryNode.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060019E5 RID: 6629 RVA: 0x00026698 File Offset: 0x00024898
		protected UEnvQueryNode(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040007A7 RID: 1959
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AIModule.EnvQueryNode";

		// Token: 0x040007A8 RID: 1960
		private static IntPtr _ClassPtr;

		// Token: 0x040007A9 RID: 1961
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040007AA RID: 1962
		internal static int __PropertyOffset_VerNum;
	}
}
