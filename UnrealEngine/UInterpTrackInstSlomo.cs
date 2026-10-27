using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000CA8 RID: 3240
	[UnrealObjectPath("/Script/Engine.InterpTrackInstSlomo")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 56)]
	public class UInterpTrackInstSlomo : UInterpTrackInst, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600A3F2 RID: 41970 RVA: 0x000E90E4 File Offset: 0x000E72E4
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UInterpTrackInstSlomo._ClassPtr;
		}

		// Token: 0x0600A3F3 RID: 41971 RVA: 0x000E90F0 File Offset: 0x000E72F0
		public UInterpTrackInstSlomo() : this(BuiltinUtils.AllocNativeUObject(UInterpTrackInstSlomo.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600A3F4 RID: 41972 RVA: 0x000E9118 File Offset: 0x000E7318
		[NullableContext(1)]
		public UInterpTrackInstSlomo(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UInterpTrackInstSlomo.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170026FD RID: 9981
		// (get) Token: 0x0600A3F5 RID: 41973 RVA: 0x000E914B File Offset: 0x000E734B
		// (set) Token: 0x0600A3F6 RID: 41974 RVA: 0x000E915B File Offset: 0x000E735B
		public unsafe float OldTimeDilation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UInterpTrackInstSlomo.__PropertyOffset_OldTimeDilation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UInterpTrackInstSlomo.__PropertyOffset_OldTimeDilation) = value;
			}
		}

		// Token: 0x0600A3F7 RID: 41975 RVA: 0x000E916C File Offset: 0x000E736C
		static UInterpTrackInstSlomo()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.InterpTrackInstSlomo");
		}

		// Token: 0x0600A3F8 RID: 41976 RVA: 0x000E917A File Offset: 0x000E737A
		protected UInterpTrackInstSlomo(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04005A1D RID: 23069
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.InterpTrackInstSlomo";

		// Token: 0x04005A1E RID: 23070
		private static IntPtr _ClassPtr;

		// Token: 0x04005A1F RID: 23071
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04005A20 RID: 23072
		internal static int __PropertyOffset_OldTimeDilation;
	}
}
