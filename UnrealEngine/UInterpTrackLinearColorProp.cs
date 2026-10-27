using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000CAF RID: 3247
	[UnrealObjectPath("/Script/Engine.InterpTrackLinearColorProp")]
	[UnrealStructLayout(216, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 216)]
	public class UInterpTrackLinearColorProp : UInterpTrackLinearColorBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600A432 RID: 42034 RVA: 0x000E9719 File Offset: 0x000E7919
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UInterpTrackLinearColorProp._ClassPtr;
		}

		// Token: 0x0600A433 RID: 42035 RVA: 0x000E9728 File Offset: 0x000E7928
		public UInterpTrackLinearColorProp() : this(BuiltinUtils.AllocNativeUObject(UInterpTrackLinearColorProp.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600A434 RID: 42036 RVA: 0x000E9750 File Offset: 0x000E7950
		[NullableContext(1)]
		public UInterpTrackLinearColorProp(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UInterpTrackLinearColorProp.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700270C RID: 9996
		// (get) Token: 0x0600A435 RID: 42037 RVA: 0x000E9783 File Offset: 0x000E7983
		// (set) Token: 0x0600A436 RID: 42038 RVA: 0x000E9797 File Offset: 0x000E7997
		public unsafe FName PropertyName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UInterpTrackLinearColorProp.__PropertyOffset_PropertyName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UInterpTrackLinearColorProp.__PropertyOffset_PropertyName) = value;
			}
		}

		// Token: 0x0600A437 RID: 42039 RVA: 0x000E97AC File Offset: 0x000E79AC
		static UInterpTrackLinearColorProp()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.InterpTrackLinearColorProp");
		}

		// Token: 0x0600A438 RID: 42040 RVA: 0x000E97BA File Offset: 0x000E79BA
		protected UInterpTrackLinearColorProp(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04005A46 RID: 23110
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.InterpTrackLinearColorProp";

		// Token: 0x04005A47 RID: 23111
		private static IntPtr _ClassPtr;

		// Token: 0x04005A48 RID: 23112
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04005A49 RID: 23113
		internal static int __PropertyOffset_PropertyName;
	}
}
