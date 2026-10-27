using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000C8C RID: 3212
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.InterpTrackBoolProp")]
	[UnrealStructLayout(200, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 200)]
	public class UInterpTrackBoolProp : UInterpTrack, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600A315 RID: 41749 RVA: 0x000E7AF2 File Offset: 0x000E5CF2
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UInterpTrackBoolProp._ClassPtr;
		}

		// Token: 0x0600A316 RID: 41750 RVA: 0x000E7B00 File Offset: 0x000E5D00
		public UInterpTrackBoolProp() : this(BuiltinUtils.AllocNativeUObject(UInterpTrackBoolProp.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600A317 RID: 41751 RVA: 0x000E7B28 File Offset: 0x000E5D28
		public UInterpTrackBoolProp(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UInterpTrackBoolProp.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170026D4 RID: 9940
		// (get) Token: 0x0600A318 RID: 41752 RVA: 0x000E7B5C File Offset: 0x000E5D5C
		// (set) Token: 0x0600A319 RID: 41753 RVA: 0x000E7B95 File Offset: 0x000E5D95
		public TArray<FBoolTrackKey> BoolTrack
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FBoolTrackKey> result;
				if ((result = this._BoolTrack) == null)
				{
					result = (this._BoolTrack = new TArray<FBoolTrackKey>(base.NativePtr + (IntPtr)UInterpTrackBoolProp.__PropertyOffset_BoolTrack, this));
				}
				return result;
			}
			set
			{
				this.BoolTrack.CopyAssign(value);
			}
		}

		// Token: 0x170026D5 RID: 9941
		// (get) Token: 0x0600A31A RID: 41754 RVA: 0x000E7BA3 File Offset: 0x000E5DA3
		// (set) Token: 0x0600A31B RID: 41755 RVA: 0x000E7BB7 File Offset: 0x000E5DB7
		public unsafe FName PropertyName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UInterpTrackBoolProp.__PropertyOffset_PropertyName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UInterpTrackBoolProp.__PropertyOffset_PropertyName) = value;
			}
		}

		// Token: 0x0600A31C RID: 41756 RVA: 0x000E7BCC File Offset: 0x000E5DCC
		static UInterpTrackBoolProp()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.InterpTrackBoolProp");
		}

		// Token: 0x0600A31D RID: 41757 RVA: 0x000E7BDA File Offset: 0x000E5DDA
		protected UInterpTrackBoolProp(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04005991 RID: 22929
		public new const string __ObjectPath = "/Script/Engine.InterpTrackBoolProp";

		// Token: 0x04005992 RID: 22930
		private static IntPtr _ClassPtr;

		// Token: 0x04005993 RID: 22931
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04005994 RID: 22932
		internal static int __PropertyOffset_BoolTrack;

		// Token: 0x04005995 RID: 22933
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FBoolTrackKey> _BoolTrack;

		// Token: 0x04005996 RID: 22934
		internal static int __PropertyOffset_PropertyName;
	}
}
