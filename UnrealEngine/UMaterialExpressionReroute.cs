using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000E28 RID: 3624
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.MaterialExpressionReroute")]
	[UnrealStructLayout(248, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 248)]
	public class UMaterialExpressionReroute : UMaterialExpressionRerouteBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600C2E7 RID: 49895 RVA: 0x00119326 File Offset: 0x00117526
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMaterialExpressionReroute._ClassPtr;
		}

		// Token: 0x0600C2E8 RID: 49896 RVA: 0x00119334 File Offset: 0x00117534
		public UMaterialExpressionReroute() : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionReroute.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600C2E9 RID: 49897 RVA: 0x0011935C File Offset: 0x0011755C
		public UMaterialExpressionReroute(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMaterialExpressionReroute.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002D32 RID: 11570
		// (get) Token: 0x0600C2EA RID: 49898 RVA: 0x00119390 File Offset: 0x00117590
		// (set) Token: 0x0600C2EB RID: 49899 RVA: 0x001193C9 File Offset: 0x001175C9
		public FExpressionInput Input
		{
			get
			{
				base.FastCheckIsValid();
				FExpressionInput result;
				if ((result = this._Input) == null)
				{
					result = (this._Input = new FExpressionInput(base.NativePtr + (IntPtr)UMaterialExpressionReroute.__PropertyOffset_Input, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FExpressionInput.StaticStruct(), base.NativePtr + (IntPtr)UMaterialExpressionReroute.__PropertyOffset_Input, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0600C2EC RID: 49900 RVA: 0x001193EA File Offset: 0x001175EA
		static UMaterialExpressionReroute()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.MaterialExpressionReroute");
		}

		// Token: 0x0600C2ED RID: 49901 RVA: 0x001193F8 File Offset: 0x001175F8
		protected UMaterialExpressionReroute(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040067D3 RID: 26579
		public new const string __ObjectPath = "/Script/Engine.MaterialExpressionReroute";

		// Token: 0x040067D4 RID: 26580
		private static IntPtr _ClassPtr;

		// Token: 0x040067D5 RID: 26581
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040067D6 RID: 26582
		internal static int __PropertyOffset_Input;

		// Token: 0x040067D7 RID: 26583
		[Nullable(2)]
		private FExpressionInput _Input;
	}
}
