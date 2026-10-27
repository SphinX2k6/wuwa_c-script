using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020009C8 RID: 2504
	[UnrealObjectPath("/Script/Engine.DistributionFloatConstant")]
	[UnrealStructLayout(72, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 72)]
	public class UDistributionFloatConstant : UDistributionFloat, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06008DCB RID: 36299 RVA: 0x000CAADD File Offset: 0x000C8CDD
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UDistributionFloatConstant._ClassPtr;
		}

		// Token: 0x06008DCC RID: 36300 RVA: 0x000CAAEC File Offset: 0x000C8CEC
		public UDistributionFloatConstant() : this(BuiltinUtils.AllocNativeUObject(UDistributionFloatConstant.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06008DCD RID: 36301 RVA: 0x000CAB14 File Offset: 0x000C8D14
		[NullableContext(1)]
		public UDistributionFloatConstant(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UDistributionFloatConstant.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17002164 RID: 8548
		// (get) Token: 0x06008DCE RID: 36302 RVA: 0x000CAB47 File Offset: 0x000C8D47
		// (set) Token: 0x06008DCF RID: 36303 RVA: 0x000CAB57 File Offset: 0x000C8D57
		public unsafe float Constant
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UDistributionFloatConstant.__PropertyOffset_Constant);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UDistributionFloatConstant.__PropertyOffset_Constant) = value;
			}
		}

		// Token: 0x06008DD0 RID: 36304 RVA: 0x000CAB68 File Offset: 0x000C8D68
		static UDistributionFloatConstant()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.DistributionFloatConstant");
		}

		// Token: 0x06008DD1 RID: 36305 RVA: 0x000CAB76 File Offset: 0x000C8D76
		protected UDistributionFloatConstant(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400434F RID: 17231
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.DistributionFloatConstant";

		// Token: 0x04004350 RID: 17232
		private static IntPtr _ClassPtr;

		// Token: 0x04004351 RID: 17233
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04004352 RID: 17234
		internal static int __PropertyOffset_Constant;
	}
}
