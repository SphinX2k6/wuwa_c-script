using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001BF1 RID: 7153
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroWuYinQuActorBase")]
	[UnrealStructLayout(1056, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1056)]
	public class AKuroWuYinQuActorBase : AActor, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601B8AA RID: 112810 RVA: 0x00288DFC File Offset: 0x00286FFC
		public new static UClassStackOnlyPtr StaticClass()
		{
			return AKuroWuYinQuActorBase._ClassPtr;
		}

		// Token: 0x0601B8AB RID: 112811 RVA: 0x00288E08 File Offset: 0x00287008
		public AKuroWuYinQuActorBase() : this(BuiltinUtils.AllocNativeUObject(AKuroWuYinQuActorBase.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601B8AC RID: 112812 RVA: 0x00288E30 File Offset: 0x00287030
		[NullableContext(1)]
		public AKuroWuYinQuActorBase(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(AKuroWuYinQuActorBase.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006EEA RID: 28394
		// (get) Token: 0x0601B8AD RID: 112813 RVA: 0x00288E63 File Offset: 0x00287063
		// (set) Token: 0x0601B8AE RID: 112814 RVA: 0x00288E77 File Offset: 0x00287077
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

		// Token: 0x0601B8AF RID: 112815 RVA: 0x00288E8C File Offset: 0x0028708C
		static AKuroWuYinQuActorBase()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRenderingRuntimeBPPlugin.KuroWuYinQuActorBase");
		}

		// Token: 0x0601B8B0 RID: 112816 RVA: 0x00288E9A File Offset: 0x0028709A
		protected AKuroWuYinQuActorBase(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400ED19 RID: 60697
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroWuYinQuActorBase";

		// Token: 0x0400ED1A RID: 60698
		private static IntPtr _ClassPtr;

		// Token: 0x0400ED1B RID: 60699
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400ED1C RID: 60700
		internal static int __PropertyOffset_Key;
	}
}
