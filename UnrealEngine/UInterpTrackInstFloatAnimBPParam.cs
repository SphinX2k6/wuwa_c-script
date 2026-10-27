using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000CA0 RID: 3232
	[UnrealObjectPath("/Script/Engine.InterpTrackInstFloatAnimBPParam")]
	[UnrealStructLayout(72, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 72)]
	public class UInterpTrackInstFloatAnimBPParam : UInterpTrackInst, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600A3AE RID: 41902 RVA: 0x000E8A7A File Offset: 0x000E6C7A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UInterpTrackInstFloatAnimBPParam._ClassPtr;
		}

		// Token: 0x0600A3AF RID: 41903 RVA: 0x000E8A88 File Offset: 0x000E6C88
		public UInterpTrackInstFloatAnimBPParam() : this(BuiltinUtils.AllocNativeUObject(UInterpTrackInstFloatAnimBPParam.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600A3B0 RID: 41904 RVA: 0x000E8AB0 File Offset: 0x000E6CB0
		[NullableContext(1)]
		public UInterpTrackInstFloatAnimBPParam(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UInterpTrackInstFloatAnimBPParam.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170026EF RID: 9967
		// (get) Token: 0x0600A3B1 RID: 41905 RVA: 0x000E8AE3 File Offset: 0x000E6CE3
		// (set) Token: 0x0600A3B2 RID: 41906 RVA: 0x000E8AF7 File Offset: 0x000E6CF7
		[Nullable(2)]
		public unsafe UAnimInstance AnimScriptInstance
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UAnimInstance>(base.NativePtr / (IntPtr)sizeof(void*) + UInterpTrackInstFloatAnimBPParam.__PropertyOffset_AnimScriptInstance);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UInterpTrackInstFloatAnimBPParam.__PropertyOffset_AnimScriptInstance, value);
			}
		}

		// Token: 0x170026F0 RID: 9968
		// (get) Token: 0x0600A3B3 RID: 41907 RVA: 0x000E8B0C File Offset: 0x000E6D0C
		// (set) Token: 0x0600A3B4 RID: 41908 RVA: 0x000E8B1C File Offset: 0x000E6D1C
		public unsafe float ResetFloat
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UInterpTrackInstFloatAnimBPParam.__PropertyOffset_ResetFloat);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UInterpTrackInstFloatAnimBPParam.__PropertyOffset_ResetFloat) = value;
			}
		}

		// Token: 0x0600A3B5 RID: 41909 RVA: 0x000E8B2D File Offset: 0x000E6D2D
		static UInterpTrackInstFloatAnimBPParam()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.InterpTrackInstFloatAnimBPParam");
		}

		// Token: 0x0600A3B6 RID: 41910 RVA: 0x000E8B3B File Offset: 0x000E6D3B
		protected UInterpTrackInstFloatAnimBPParam(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040059F4 RID: 23028
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.InterpTrackInstFloatAnimBPParam";

		// Token: 0x040059F5 RID: 23029
		private static IntPtr _ClassPtr;

		// Token: 0x040059F6 RID: 23030
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040059F7 RID: 23031
		internal static int __PropertyOffset_AnimScriptInstance;

		// Token: 0x040059F8 RID: 23032
		internal static int __PropertyOffset_ResetFloat;
	}
}
