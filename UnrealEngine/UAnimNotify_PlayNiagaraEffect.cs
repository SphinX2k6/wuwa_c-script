using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020024C5 RID: 9413
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/NiagaraAnimNotifies.AnimNotify_PlayNiagaraEffect")]
	[UnrealStructLayout(160, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 160)]
	public class UAnimNotify_PlayNiagaraEffect : UAnimNotify, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0602338E RID: 144270 RVA: 0x0034198B File Offset: 0x0033FB8B
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UAnimNotify_PlayNiagaraEffect._ClassPtr;
		}

		// Token: 0x0602338F RID: 144271 RVA: 0x00341998 File Offset: 0x0033FB98
		public UAnimNotify_PlayNiagaraEffect() : this(BuiltinUtils.AllocNativeUObject(UAnimNotify_PlayNiagaraEffect.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06023390 RID: 144272 RVA: 0x003419C0 File Offset: 0x0033FBC0
		[NullableContext(1)]
		public UAnimNotify_PlayNiagaraEffect(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UAnimNotify_PlayNiagaraEffect.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x1700876C RID: 34668
		// (get) Token: 0x06023391 RID: 144273 RVA: 0x003419F3 File Offset: 0x0033FBF3
		// (set) Token: 0x06023392 RID: 144274 RVA: 0x00341A07 File Offset: 0x0033FC07
		public unsafe UNiagaraSystem Template
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UNiagaraSystem>(base.NativePtr / (IntPtr)sizeof(void*) + UAnimNotify_PlayNiagaraEffect.__PropertyOffset_Template);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UAnimNotify_PlayNiagaraEffect.__PropertyOffset_Template, value);
			}
		}

		// Token: 0x1700876D RID: 34669
		// (get) Token: 0x06023393 RID: 144275 RVA: 0x00341A1C File Offset: 0x0033FC1C
		// (set) Token: 0x06023394 RID: 144276 RVA: 0x00341A30 File Offset: 0x0033FC30
		public unsafe FVector LocationOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAnimNotify_PlayNiagaraEffect.__PropertyOffset_LocationOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAnimNotify_PlayNiagaraEffect.__PropertyOffset_LocationOffset) = value;
			}
		}

		// Token: 0x1700876E RID: 34670
		// (get) Token: 0x06023395 RID: 144277 RVA: 0x00341A45 File Offset: 0x0033FC45
		// (set) Token: 0x06023396 RID: 144278 RVA: 0x00341A59 File Offset: 0x0033FC59
		public unsafe FRotator RotationOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAnimNotify_PlayNiagaraEffect.__PropertyOffset_RotationOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAnimNotify_PlayNiagaraEffect.__PropertyOffset_RotationOffset) = value;
			}
		}

		// Token: 0x1700876F RID: 34671
		// (get) Token: 0x06023397 RID: 144279 RVA: 0x00341A6E File Offset: 0x0033FC6E
		// (set) Token: 0x06023398 RID: 144280 RVA: 0x00341A82 File Offset: 0x0033FC82
		public unsafe FVector Scale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAnimNotify_PlayNiagaraEffect.__PropertyOffset_Scale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAnimNotify_PlayNiagaraEffect.__PropertyOffset_Scale) = value;
			}
		}

		// Token: 0x17008770 RID: 34672
		// (get) Token: 0x06023399 RID: 144281 RVA: 0x00341A97 File Offset: 0x0033FC97
		// (set) Token: 0x0602339A RID: 144282 RVA: 0x00341AA7 File Offset: 0x0033FCA7
		public unsafe bool bAbsoluteScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAnimNotify_PlayNiagaraEffect.__PropertyOffset_bAbsoluteScale) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAnimNotify_PlayNiagaraEffect.__PropertyOffset_bAbsoluteScale) = (value ? 1 : 0);
			}
		}

		// Token: 0x17008771 RID: 34673
		// (get) Token: 0x0602339B RID: 144283 RVA: 0x00341AB8 File Offset: 0x0033FCB8
		// (set) Token: 0x0602339C RID: 144284 RVA: 0x00341AD1 File Offset: 0x0033FCD1
		public unsafe bool Attached
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UAnimNotify_PlayNiagaraEffect.__PropertyOffset_Attached) & UAnimNotify_PlayNiagaraEffect.__PropertyMask_Attached) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UAnimNotify_PlayNiagaraEffect.__PropertyOffset_Attached) = ((*(base.NativePtr + (IntPtr)UAnimNotify_PlayNiagaraEffect.__PropertyOffset_Attached) & ~UAnimNotify_PlayNiagaraEffect.__PropertyMask_Attached) | (value ? UAnimNotify_PlayNiagaraEffect.__PropertyMask_Attached : 0));
			}
		}

		// Token: 0x17008772 RID: 34674
		// (get) Token: 0x0602339D RID: 144285 RVA: 0x00341B01 File Offset: 0x0033FD01
		// (set) Token: 0x0602339E RID: 144286 RVA: 0x00341B15 File Offset: 0x0033FD15
		public unsafe FName SocketName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UAnimNotify_PlayNiagaraEffect.__PropertyOffset_SocketName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UAnimNotify_PlayNiagaraEffect.__PropertyOffset_SocketName) = value;
			}
		}

		// Token: 0x0602339F RID: 144287 RVA: 0x00341B2A File Offset: 0x0033FD2A
		public UFXSystemComponent GetSpawnedEffect()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UFXSystemComponent>(UAnimNotify_PlayNiagaraEffect.__GetSpawnedEffect_Internal(base.NativePtr));
		}

		// Token: 0x060233A0 RID: 144288
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetSpawnedEffect_Internal(IntPtr @this);

		// Token: 0x060233A1 RID: 144289 RVA: 0x00341B3C File Offset: 0x0033FD3C
		static UAnimNotify_PlayNiagaraEffect()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/NiagaraAnimNotifies.AnimNotify_PlayNiagaraEffect");
		}

		// Token: 0x060233A2 RID: 144290 RVA: 0x00341B4A File Offset: 0x0033FD4A
		protected UAnimNotify_PlayNiagaraEffect(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04012D00 RID: 77056
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/NiagaraAnimNotifies.AnimNotify_PlayNiagaraEffect";

		// Token: 0x04012D01 RID: 77057
		private static IntPtr _ClassPtr;

		// Token: 0x04012D02 RID: 77058
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04012D03 RID: 77059
		internal static int __PropertyOffset_Template;

		// Token: 0x04012D04 RID: 77060
		internal static int __PropertyOffset_LocationOffset;

		// Token: 0x04012D05 RID: 77061
		internal static int __PropertyOffset_RotationOffset;

		// Token: 0x04012D06 RID: 77062
		internal static int __PropertyOffset_Scale;

		// Token: 0x04012D07 RID: 77063
		internal static int __PropertyOffset_bAbsoluteScale;

		// Token: 0x04012D08 RID: 77064
		internal static int __PropertyOffset_Attached;

		// Token: 0x04012D09 RID: 77065
		internal static byte __PropertyMask_Attached;

		// Token: 0x04012D0A RID: 77066
		internal static int __PropertyOffset_SocketName;
	}
}
