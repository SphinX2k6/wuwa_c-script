using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020026D8 RID: 9944
	[UnrealObjectPath("/Script/RoadNetRuntime.RoadNetSetting")]
	[UnrealStructLayout(64, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 64)]
	public class URoadNetSetting : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06024E85 RID: 151173 RVA: 0x003696EA File Offset: 0x003678EA
		public new static UClassStackOnlyPtr StaticClass()
		{
			return URoadNetSetting._ClassPtr;
		}

		// Token: 0x06024E86 RID: 151174 RVA: 0x003696F8 File Offset: 0x003678F8
		public URoadNetSetting() : this(BuiltinUtils.AllocNativeUObject(URoadNetSetting.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06024E87 RID: 151175 RVA: 0x00369720 File Offset: 0x00367920
		[NullableContext(1)]
		public URoadNetSetting(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(URoadNetSetting.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17008E88 RID: 36488
		// (get) Token: 0x06024E88 RID: 151176 RVA: 0x00369753 File Offset: 0x00367953
		// (set) Token: 0x06024E89 RID: 151177 RVA: 0x00369767 File Offset: 0x00367967
		public unsafe FVector NodePlaceOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)URoadNetSetting.__PropertyOffset_NodePlaceOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)URoadNetSetting.__PropertyOffset_NodePlaceOffset) = value;
			}
		}

		// Token: 0x06024E8A RID: 151178 RVA: 0x0036977C File Offset: 0x0036797C
		static URoadNetSetting()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/RoadNetRuntime.RoadNetSetting");
		}

		// Token: 0x06024E8B RID: 151179 RVA: 0x0036978A File Offset: 0x0036798A
		protected URoadNetSetting(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04013E1D RID: 81437
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/RoadNetRuntime.RoadNetSetting";

		// Token: 0x04013E1E RID: 81438
		private static IntPtr _ClassPtr;

		// Token: 0x04013E1F RID: 81439
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04013E20 RID: 81440
		internal static int __PropertyOffset_NodePlaceOffset;
	}
}
