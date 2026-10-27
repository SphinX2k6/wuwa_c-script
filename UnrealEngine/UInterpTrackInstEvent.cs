using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000C9E RID: 3230
	[UnrealObjectPath("/Script/Engine.InterpTrackInstEvent")]
	[UnrealStructLayout(56, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 56)]
	public class UInterpTrackInstEvent : UInterpTrackInst, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600A3A2 RID: 41890 RVA: 0x000E895B File Offset: 0x000E6B5B
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UInterpTrackInstEvent._ClassPtr;
		}

		// Token: 0x0600A3A3 RID: 41891 RVA: 0x000E8968 File Offset: 0x000E6B68
		public UInterpTrackInstEvent() : this(BuiltinUtils.AllocNativeUObject(UInterpTrackInstEvent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600A3A4 RID: 41892 RVA: 0x000E8990 File Offset: 0x000E6B90
		[NullableContext(1)]
		public UInterpTrackInstEvent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UInterpTrackInstEvent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170026EE RID: 9966
		// (get) Token: 0x0600A3A5 RID: 41893 RVA: 0x000E89C3 File Offset: 0x000E6BC3
		// (set) Token: 0x0600A3A6 RID: 41894 RVA: 0x000E89D3 File Offset: 0x000E6BD3
		public unsafe float LastUpdatePosition
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UInterpTrackInstEvent.__PropertyOffset_LastUpdatePosition);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UInterpTrackInstEvent.__PropertyOffset_LastUpdatePosition) = value;
			}
		}

		// Token: 0x0600A3A7 RID: 41895 RVA: 0x000E89E4 File Offset: 0x000E6BE4
		static UInterpTrackInstEvent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.InterpTrackInstEvent");
		}

		// Token: 0x0600A3A8 RID: 41896 RVA: 0x000E89F2 File Offset: 0x000E6BF2
		protected UInterpTrackInstEvent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040059ED RID: 23021
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.InterpTrackInstEvent";

		// Token: 0x040059EE RID: 23022
		private static IntPtr _ClassPtr;

		// Token: 0x040059EF RID: 23023
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040059F0 RID: 23024
		internal static int __PropertyOffset_LastUpdatePosition;
	}
}
