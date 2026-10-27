using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200215F RID: 8543
	[UnrealObjectPath("/Script/LGUI.UIEffectTextAnimation_ScaleProperty")]
	[UnrealStructLayout(104, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 104)]
	public class UUIEffectTextAnimation_ScaleProperty : UUIEffectTextAnimation_PropertyWithEase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06020387 RID: 131975 RVA: 0x002FD926 File Offset: 0x002FBB26
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UUIEffectTextAnimation_ScaleProperty._ClassPtr;
		}

		// Token: 0x06020388 RID: 131976 RVA: 0x002FD934 File Offset: 0x002FBB34
		public UUIEffectTextAnimation_ScaleProperty() : this(BuiltinUtils.AllocNativeUObject(UUIEffectTextAnimation_ScaleProperty.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06020389 RID: 131977 RVA: 0x002FD95C File Offset: 0x002FBB5C
		[NullableContext(1)]
		public UUIEffectTextAnimation_ScaleProperty(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UUIEffectTextAnimation_ScaleProperty.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17007E5A RID: 32346
		// (get) Token: 0x0602038A RID: 131978 RVA: 0x002FD98F File Offset: 0x002FBB8F
		// (set) Token: 0x0602038B RID: 131979 RVA: 0x002FD9A3 File Offset: 0x002FBBA3
		public unsafe FVector scale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIEffectTextAnimation_ScaleProperty.__PropertyOffset_scale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIEffectTextAnimation_ScaleProperty.__PropertyOffset_scale) = value;
			}
		}

		// Token: 0x17007E5B RID: 32347
		// (get) Token: 0x0602038C RID: 131980 RVA: 0x002FD9B8 File Offset: 0x002FBBB8
		// (set) Token: 0x0602038D RID: 131981 RVA: 0x002FD9CC File Offset: 0x002FBBCC
		public unsafe FVector initialScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UUIEffectTextAnimation_ScaleProperty.__PropertyOffset_initialScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UUIEffectTextAnimation_ScaleProperty.__PropertyOffset_initialScale) = value;
			}
		}

		// Token: 0x0602038E RID: 131982 RVA: 0x002FD9E1 File Offset: 0x002FBBE1
		public void SetScale(FVector value)
		{
			UUIEffectTextAnimation_ScaleProperty.__SetScale_Internal(base.NativePtr, value);
		}

		// Token: 0x0602038F RID: 131983 RVA: 0x002FD9EF File Offset: 0x002FBBEF
		public FVector GetScale()
		{
			return UUIEffectTextAnimation_ScaleProperty.__GetScale_Internal(base.NativePtr);
		}

		// Token: 0x06020390 RID: 131984
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetScale_Internal(IntPtr @this, FVector value);

		// Token: 0x06020391 RID: 131985
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __GetScale_Internal(IntPtr @this);

		// Token: 0x06020392 RID: 131986 RVA: 0x002FD9FC File Offset: 0x002FBBFC
		static UUIEffectTextAnimation_ScaleProperty()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/LGUI.UIEffectTextAnimation_ScaleProperty");
		}

		// Token: 0x06020393 RID: 131987 RVA: 0x002FDA0A File Offset: 0x002FBC0A
		protected UUIEffectTextAnimation_ScaleProperty(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011505 RID: 70917
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/LGUI.UIEffectTextAnimation_ScaleProperty";

		// Token: 0x04011506 RID: 70918
		private static IntPtr _ClassPtr;

		// Token: 0x04011507 RID: 70919
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04011508 RID: 70920
		internal static int __PropertyOffset_scale;

		// Token: 0x04011509 RID: 70921
		internal static int __PropertyOffset_initialScale;
	}
}
