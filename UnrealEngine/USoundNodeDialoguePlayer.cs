using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200113F RID: 4415
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.SoundNodeDialoguePlayer")]
	[UnrealStructLayout(128, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 128)]
	public class USoundNodeDialoguePlayer : USoundNode, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06010244 RID: 66116 RVA: 0x0017C890 File Offset: 0x0017AA90
		public new static UClassStackOnlyPtr StaticClass()
		{
			return USoundNodeDialoguePlayer._ClassPtr;
		}

		// Token: 0x06010245 RID: 66117 RVA: 0x0017C89C File Offset: 0x0017AA9C
		public USoundNodeDialoguePlayer() : this(BuiltinUtils.AllocNativeUObject(USoundNodeDialoguePlayer.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06010246 RID: 66118 RVA: 0x0017C8C4 File Offset: 0x0017AAC4
		public USoundNodeDialoguePlayer(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(USoundNodeDialoguePlayer.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003F31 RID: 16177
		// (get) Token: 0x06010247 RID: 66119 RVA: 0x0017C8F8 File Offset: 0x0017AAF8
		// (set) Token: 0x06010248 RID: 66120 RVA: 0x0017C931 File Offset: 0x0017AB31
		public FDialogueWaveParameter DialogueWaveParameter
		{
			get
			{
				base.FastCheckIsValid();
				FDialogueWaveParameter result;
				if ((result = this._DialogueWaveParameter) == null)
				{
					result = (this._DialogueWaveParameter = new FDialogueWaveParameter(base.NativePtr + (IntPtr)USoundNodeDialoguePlayer.__PropertyOffset_DialogueWaveParameter, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FDialogueWaveParameter.StaticStruct(), base.NativePtr + (IntPtr)USoundNodeDialoguePlayer.__PropertyOffset_DialogueWaveParameter, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17003F32 RID: 16178
		// (get) Token: 0x06010249 RID: 66121 RVA: 0x0017C952 File Offset: 0x0017AB52
		// (set) Token: 0x0601024A RID: 66122 RVA: 0x0017C96B File Offset: 0x0017AB6B
		public unsafe bool bLooping
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)USoundNodeDialoguePlayer.__PropertyOffset_bLooping) & USoundNodeDialoguePlayer.__PropertyMask_bLooping) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)USoundNodeDialoguePlayer.__PropertyOffset_bLooping) = ((*(base.NativePtr + (IntPtr)USoundNodeDialoguePlayer.__PropertyOffset_bLooping) & ~USoundNodeDialoguePlayer.__PropertyMask_bLooping) | (value ? USoundNodeDialoguePlayer.__PropertyMask_bLooping : 0));
			}
		}

		// Token: 0x0601024B RID: 66123 RVA: 0x0017C99B File Offset: 0x0017AB9B
		static USoundNodeDialoguePlayer()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.SoundNodeDialoguePlayer");
		}

		// Token: 0x0601024C RID: 66124 RVA: 0x0017C9A9 File Offset: 0x0017ABA9
		protected USoundNodeDialoguePlayer(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04008AEA RID: 35562
		public new const string __ObjectPath = "/Script/Engine.SoundNodeDialoguePlayer";

		// Token: 0x04008AEB RID: 35563
		private static IntPtr _ClassPtr;

		// Token: 0x04008AEC RID: 35564
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04008AED RID: 35565
		internal static int __PropertyOffset_DialogueWaveParameter;

		// Token: 0x04008AEE RID: 35566
		[Nullable(2)]
		private FDialogueWaveParameter _DialogueWaveParameter;

		// Token: 0x04008AEF RID: 35567
		internal static int __PropertyOffset_bLooping;

		// Token: 0x04008AF0 RID: 35568
		internal static byte __PropertyMask_bLooping;
	}
}
