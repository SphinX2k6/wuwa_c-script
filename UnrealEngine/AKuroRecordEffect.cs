using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001672 RID: 5746
	[UnrealObjectPath("/Script/KuroAnim.KuroRecordEffect")]
	[UnrealStructLayout(1040, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1040)]
	public class AKuroRecordEffect : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06014D92 RID: 85394 RVA: 0x001EA7A3 File Offset: 0x001E89A3
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AKuroRecordEffect._ClassPtr;
		}

		// Token: 0x06014D93 RID: 85395 RVA: 0x001EA7B0 File Offset: 0x001E89B0
		public AKuroRecordEffect() : this(BuiltinUtils.AllocNativeUObject(AKuroRecordEffect.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06014D94 RID: 85396 RVA: 0x001EA7D8 File Offset: 0x001E89D8
		[NullableContext(1)]
		public AKuroRecordEffect(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AKuroRecordEffect.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06014D95 RID: 85397 RVA: 0x001EA80B File Offset: 0x001E8A0B
		public void Stop()
		{
			AKuroRecordEffect.__Stop_Internal(base.NativePtr);
		}

		// Token: 0x06014D96 RID: 85398 RVA: 0x001EA818 File Offset: 0x001E8A18
		public void Play()
		{
			AKuroRecordEffect.__Play_Internal(base.NativePtr);
		}

		// Token: 0x06014D97 RID: 85399 RVA: 0x001EA825 File Offset: 0x001E8A25
		public virtual void OnStop()
		{
			AKuroRecordEffect.__OnStop_Internal(base.NativePtr);
		}

		// Token: 0x06014D98 RID: 85400 RVA: 0x001EA832 File Offset: 0x001E8A32
		public virtual void OnPlay()
		{
			AKuroRecordEffect.__OnPlay_Internal(base.NativePtr);
		}

		// Token: 0x06014D99 RID: 85401
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Stop_Internal(IntPtr @this);

		// Token: 0x06014D9A RID: 85402
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Play_Internal(IntPtr @this);

		// Token: 0x06014D9B RID: 85403
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnStop_Internal(IntPtr @this);

		// Token: 0x06014D9C RID: 85404
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnPlay_Internal(IntPtr @this);

		// Token: 0x06014D9D RID: 85405 RVA: 0x001EA83F File Offset: 0x001E8A3F
		static AKuroRecordEffect()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroAnim.KuroRecordEffect");
		}

		// Token: 0x06014D9E RID: 85406 RVA: 0x001EA84D File Offset: 0x001E8A4D
		protected AKuroRecordEffect(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400B5D1 RID: 46545
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroAnim.KuroRecordEffect";

		// Token: 0x0400B5D2 RID: 46546
		private static IntPtr _ClassPtr;

		// Token: 0x0400B5D3 RID: 46547
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
