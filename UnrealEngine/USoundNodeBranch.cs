using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200113C RID: 4412
	[UnrealObjectPath("/Script/Engine.SoundNodeBranch")]
	[UnrealStructLayout(104, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 104)]
	public class USoundNodeBranch : USoundNode, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601022D RID: 66093 RVA: 0x0017C65E File Offset: 0x0017A85E
		public new static UClassStackOnlyPtr StaticClass()
		{
			return USoundNodeBranch._ClassPtr;
		}

		// Token: 0x0601022E RID: 66094 RVA: 0x0017C66C File Offset: 0x0017A86C
		public USoundNodeBranch() : this(BuiltinUtils.AllocNativeUObject(USoundNodeBranch.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601022F RID: 66095 RVA: 0x0017C694 File Offset: 0x0017A894
		[NullableContext(1)]
		public USoundNodeBranch(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(USoundNodeBranch.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003F2D RID: 16173
		// (get) Token: 0x06010230 RID: 66096 RVA: 0x0017C6C7 File Offset: 0x0017A8C7
		// (set) Token: 0x06010231 RID: 66097 RVA: 0x0017C6DB File Offset: 0x0017A8DB
		public unsafe FName BoolParameterName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USoundNodeBranch.__PropertyOffset_BoolParameterName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USoundNodeBranch.__PropertyOffset_BoolParameterName) = value;
			}
		}

		// Token: 0x06010232 RID: 66098 RVA: 0x0017C6F0 File Offset: 0x0017A8F0
		static USoundNodeBranch()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.SoundNodeBranch");
		}

		// Token: 0x06010233 RID: 66099 RVA: 0x0017C6FE File Offset: 0x0017A8FE
		protected USoundNodeBranch(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04008ADC RID: 35548
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.SoundNodeBranch";

		// Token: 0x04008ADD RID: 35549
		private static IntPtr _ClassPtr;

		// Token: 0x04008ADE RID: 35550
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04008ADF RID: 35551
		internal static int __PropertyOffset_BoolParameterName;
	}
}
