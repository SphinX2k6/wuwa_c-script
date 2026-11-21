using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020002FF RID: 767
	[UnrealObjectPath("/Script/KuroAnim.KuroRecordEffect")]
	[UnrealStructLayout(1040, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1040)]
	public class AKuroRecordEffect : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060052C0 RID: 21184 RVA: 0x00073B5F File Offset: 0x00071D5F
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AKuroRecordEffect._ClassPtr;
		}

		// Token: 0x060052C1 RID: 21185 RVA: 0x00073B6C File Offset: 0x00071D6C
		public AKuroRecordEffect() : this(BuiltinUtils.AllocNativeUObject(AKuroRecordEffect.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060052C2 RID: 21186 RVA: 0x00073B94 File Offset: 0x00071D94
		[NullableContext(1)]
		public AKuroRecordEffect(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AKuroRecordEffect.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x060052C3 RID: 21187 RVA: 0x00073BC7 File Offset: 0x00071DC7
		public void Stop()
		{
			AKuroRecordEffect.__Stop_Internal(base.NativePtr);
		}

		// Token: 0x060052C4 RID: 21188 RVA: 0x00073BD4 File Offset: 0x00071DD4
		public void Play()
		{
			AKuroRecordEffect.__Play_Internal(base.NativePtr);
		}

		// Token: 0x060052C5 RID: 21189 RVA: 0x00073BE1 File Offset: 0x00071DE1
		public virtual void OnStop()
		{
			AKuroRecordEffect.__OnStop_Internal(base.NativePtr);
		}

		// Token: 0x060052C6 RID: 21190 RVA: 0x00073BEE File Offset: 0x00071DEE
		public virtual void OnPlay()
		{
			AKuroRecordEffect.__OnPlay_Internal(base.NativePtr);
		}

		// Token: 0x060052C7 RID: 21191
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Stop_Internal(IntPtr @this);

		// Token: 0x060052C8 RID: 21192
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Play_Internal(IntPtr @this);

		// Token: 0x060052C9 RID: 21193
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnStop_Internal(IntPtr @this);

		// Token: 0x060052CA RID: 21194
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OnPlay_Internal(IntPtr @this);

		// Token: 0x060052CB RID: 21195 RVA: 0x00073BFB File Offset: 0x00071DFB
		static AKuroRecordEffect()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroAnim.KuroRecordEffect");
		}

		// Token: 0x060052CC RID: 21196 RVA: 0x00073C09 File Offset: 0x00071E09
		protected AKuroRecordEffect(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040021C1 RID: 8641
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroAnim.KuroRecordEffect";

		// Token: 0x040021C2 RID: 8642
		private static IntPtr _ClassPtr;

		// Token: 0x040021C3 RID: 8643
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
