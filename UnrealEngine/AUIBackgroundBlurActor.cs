using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002129 RID: 8489
	[UnrealObjectPath("/Script/LGUI.UIBackgroundBlurActor")]
	[UnrealStructLayout(1672, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1672)]
	public class AUIBackgroundBlurActor : AUIPostProcessBaseActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601FF0A RID: 130826 RVA: 0x002F80B6 File Offset: 0x002F62B6
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AUIBackgroundBlurActor._ClassPtr;
		}

		// Token: 0x0601FF0B RID: 130827 RVA: 0x002F80C4 File Offset: 0x002F62C4
		public AUIBackgroundBlurActor() : this(BuiltinUtils.AllocNativeUObject(AUIBackgroundBlurActor.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601FF0C RID: 130828 RVA: 0x002F80EC File Offset: 0x002F62EC
		[NullableContext(1)]
		public AUIBackgroundBlurActor(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AUIBackgroundBlurActor.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007D8C RID: 32140
		// (get) Token: 0x0601FF0D RID: 130829 RVA: 0x002F811F File Offset: 0x002F631F
		// (set) Token: 0x0601FF0E RID: 130830 RVA: 0x002F8133 File Offset: 0x002F6333
		[Nullable(2)]
		public unsafe UUIBackgroundBlur UIBackgroundBlur
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UUIBackgroundBlur>(base.NativePtr / (IntPtr)sizeof(void*) + AUIBackgroundBlurActor.__PropertyOffset_UIBackgroundBlur);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AUIBackgroundBlurActor.__PropertyOffset_UIBackgroundBlur, value);
			}
		}

		// Token: 0x0601FF0F RID: 130831 RVA: 0x002F8148 File Offset: 0x002F6348
		static AUIBackgroundBlurActor()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.UIBackgroundBlurActor");
		}

		// Token: 0x0601FF10 RID: 130832 RVA: 0x002F8156 File Offset: 0x002F6356
		protected AUIBackgroundBlurActor(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011345 RID: 70469
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LGUI.UIBackgroundBlurActor";

		// Token: 0x04011346 RID: 70470
		private static IntPtr _ClassPtr;

		// Token: 0x04011347 RID: 70471
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04011348 RID: 70472
		internal static int __PropertyOffset_UIBackgroundBlur;
	}
}
