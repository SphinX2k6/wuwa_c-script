using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001145 RID: 4421
	[UnrealObjectPath("/Script/Engine.SoundNodeLooping")]
	[UnrealStructLayout(96, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 96)]
	public class USoundNodeLooping : USoundNode, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601028E RID: 66190 RVA: 0x0017CFAA File Offset: 0x0017B1AA
		public new static UClassStackOnlyPtr StaticClass()
		{
			return USoundNodeLooping._ClassPtr;
		}

		// Token: 0x0601028F RID: 66191 RVA: 0x0017CFB8 File Offset: 0x0017B1B8
		public USoundNodeLooping() : this(BuiltinUtils.AllocNativeUObject(USoundNodeLooping.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06010290 RID: 66192 RVA: 0x0017CFE0 File Offset: 0x0017B1E0
		[NullableContext(1)]
		public USoundNodeLooping(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(USoundNodeLooping.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003F46 RID: 16198
		// (get) Token: 0x06010291 RID: 66193 RVA: 0x0017D013 File Offset: 0x0017B213
		// (set) Token: 0x06010292 RID: 66194 RVA: 0x0017D023 File Offset: 0x0017B223
		public unsafe int LoopCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USoundNodeLooping.__PropertyOffset_LoopCount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USoundNodeLooping.__PropertyOffset_LoopCount) = value;
			}
		}

		// Token: 0x17003F47 RID: 16199
		// (get) Token: 0x06010293 RID: 66195 RVA: 0x0017D034 File Offset: 0x0017B234
		// (set) Token: 0x06010294 RID: 66196 RVA: 0x0017D04D File Offset: 0x0017B24D
		public unsafe bool bLoopIndefinitely
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)USoundNodeLooping.__PropertyOffset_bLoopIndefinitely) & USoundNodeLooping.__PropertyMask_bLoopIndefinitely) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)USoundNodeLooping.__PropertyOffset_bLoopIndefinitely) = ((*(base.NativePtr + (IntPtr)USoundNodeLooping.__PropertyOffset_bLoopIndefinitely) & ~USoundNodeLooping.__PropertyMask_bLoopIndefinitely) | (value ? USoundNodeLooping.__PropertyMask_bLoopIndefinitely : 0));
			}
		}

		// Token: 0x06010295 RID: 66197 RVA: 0x0017D07D File Offset: 0x0017B27D
		static USoundNodeLooping()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.SoundNodeLooping");
		}

		// Token: 0x06010296 RID: 66198 RVA: 0x0017D08B File Offset: 0x0017B28B
		protected USoundNodeLooping(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04008B18 RID: 35608
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.SoundNodeLooping";

		// Token: 0x04008B19 RID: 35609
		private static IntPtr _ClassPtr;

		// Token: 0x04008B1A RID: 35610
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04008B1B RID: 35611
		internal static int __PropertyOffset_LoopCount;

		// Token: 0x04008B1C RID: 35612
		internal static int __PropertyOffset_bLoopIndefinitely;

		// Token: 0x04008B1D RID: 35613
		internal static byte __PropertyMask_bLoopIndefinitely;
	}
}
