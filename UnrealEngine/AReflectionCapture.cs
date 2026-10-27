using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001078 RID: 4216
	[UnrealObjectPath("/Script/Engine.ReflectionCapture")]
	[UnrealStructLayout(1064, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1064)]
	public abstract class AReflectionCapture : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600EFE5 RID: 61413 RVA: 0x00163A4B File Offset: 0x00161C4B
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AReflectionCapture._ClassPtr;
		}

		// Token: 0x17003A0E RID: 14862
		// (get) Token: 0x0600EFE6 RID: 61414 RVA: 0x00163A57 File Offset: 0x00161C57
		// (set) Token: 0x0600EFE7 RID: 61415 RVA: 0x00163A6B File Offset: 0x00161C6B
		[Nullable(2)]
		public unsafe UReflectionCaptureComponent CaptureComponent
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UReflectionCaptureComponent>(base.NativePtr / (IntPtr)sizeof(void*) + AReflectionCapture.__PropertyOffset_CaptureComponent);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + AReflectionCapture.__PropertyOffset_CaptureComponent, value);
			}
		}

		// Token: 0x0600EFE8 RID: 61416 RVA: 0x00163A80 File Offset: 0x00161C80
		static AReflectionCapture()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.ReflectionCapture");
		}

		// Token: 0x0600EFE9 RID: 61417 RVA: 0x00163A90 File Offset: 0x00161C90
		protected AReflectionCapture() : this(BuiltinUtils.AllocNativeUObject(AReflectionCapture.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600EFEA RID: 61418 RVA: 0x00163AB8 File Offset: 0x00161CB8
		protected AReflectionCapture(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040081C0 RID: 33216
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.ReflectionCapture";

		// Token: 0x040081C1 RID: 33217
		private static IntPtr _ClassPtr;

		// Token: 0x040081C2 RID: 33218
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040081C3 RID: 33219
		internal static int __PropertyOffset_CaptureComponent;
	}
}
