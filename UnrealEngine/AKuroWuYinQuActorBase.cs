using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020004EE RID: 1262
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroWuYinQuActorBase")]
	[UnrealStructLayout(1056, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1056)]
	public class AKuroWuYinQuActorBase : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06007709 RID: 30473 RVA: 0x000ADE4A File Offset: 0x000AC04A
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AKuroWuYinQuActorBase._ClassPtr;
		}

		// Token: 0x0600770A RID: 30474 RVA: 0x000ADE58 File Offset: 0x000AC058
		public AKuroWuYinQuActorBase() : this(BuiltinUtils.AllocNativeUObject(AKuroWuYinQuActorBase.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600770B RID: 30475 RVA: 0x000ADE80 File Offset: 0x000AC080
		[NullableContext(1)]
		public AKuroWuYinQuActorBase(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AKuroWuYinQuActorBase.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170016FA RID: 5882
		// (get) Token: 0x0600770C RID: 30476 RVA: 0x000ADEB3 File Offset: 0x000AC0B3
		// (set) Token: 0x0600770D RID: 30477 RVA: 0x000ADEC7 File Offset: 0x000AC0C7
		public unsafe FName Key
		{
			get
			{
				return *(base.NativePtr + (IntPtr)AKuroWuYinQuActorBase.__PropertyOffset_Key);
			}
			set
			{
				*(base.NativePtr + (IntPtr)AKuroWuYinQuActorBase.__PropertyOffset_Key) = value;
			}
		}

		// Token: 0x0600770E RID: 30478 RVA: 0x000ADEDC File Offset: 0x000AC0DC
		static AKuroWuYinQuActorBase()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRenderingRuntimeBPPlugin.KuroWuYinQuActorBase");
		}

		// Token: 0x0600770F RID: 30479 RVA: 0x000ADEEA File Offset: 0x000AC0EA
		protected AKuroWuYinQuActorBase(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04003231 RID: 12849
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroWuYinQuActorBase";

		// Token: 0x04003232 RID: 12850
		private static IntPtr _ClassPtr;

		// Token: 0x04003233 RID: 12851
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04003234 RID: 12852
		internal static int __PropertyOffset_Key;
	}
}
