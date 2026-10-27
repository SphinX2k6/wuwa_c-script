using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020010A8 RID: 4264
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.ROscillator")]
	[UnrealStructLayout(36, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 36)]
	public class FROscillator : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600F3D0 RID: 62416 RVA: 0x00169978 File Offset: 0x00167B78
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FROscillator._ScriptStructPtr != 0) ? FROscillator._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.ROscillator", ref FROscillator._ScriptStructPtr);
		}

		// Token: 0x17003B66 RID: 15206
		// (get) Token: 0x0600F3D1 RID: 62417 RVA: 0x0016999C File Offset: 0x00167B9C
		// (set) Token: 0x0600F3D2 RID: 62418 RVA: 0x001699DF File Offset: 0x00167BDF
		public FFOscillator Pitch
		{
			get
			{
				base.FastCheckIsValid();
				FFOscillator result;
				if ((result = this._Pitch) == null)
				{
					result = (this._Pitch = new FFOscillator(base.NativePtr + (IntPtr)FROscillator.__PropertyOffset_Pitch, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FFOscillator.StaticStruct(), base.NativePtr + (IntPtr)FROscillator.__PropertyOffset_Pitch, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17003B67 RID: 15207
		// (get) Token: 0x0600F3D3 RID: 62419 RVA: 0x00169A00 File Offset: 0x00167C00
		// (set) Token: 0x0600F3D4 RID: 62420 RVA: 0x00169A43 File Offset: 0x00167C43
		public FFOscillator Yaw
		{
			get
			{
				base.FastCheckIsValid();
				FFOscillator result;
				if ((result = this._Yaw) == null)
				{
					result = (this._Yaw = new FFOscillator(base.NativePtr + (IntPtr)FROscillator.__PropertyOffset_Yaw, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FFOscillator.StaticStruct(), base.NativePtr + (IntPtr)FROscillator.__PropertyOffset_Yaw, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17003B68 RID: 15208
		// (get) Token: 0x0600F3D5 RID: 62421 RVA: 0x00169A64 File Offset: 0x00167C64
		// (set) Token: 0x0600F3D6 RID: 62422 RVA: 0x00169AA7 File Offset: 0x00167CA7
		public FFOscillator Roll
		{
			get
			{
				base.FastCheckIsValid();
				FFOscillator result;
				if ((result = this._Roll) == null)
				{
					result = (this._Roll = new FFOscillator(base.NativePtr + (IntPtr)FROscillator.__PropertyOffset_Roll, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FFOscillator.StaticStruct(), base.NativePtr + (IntPtr)FROscillator.__PropertyOffset_Roll, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0600F3D7 RID: 62423 RVA: 0x00169AC8 File Offset: 0x00167CC8
		public FROscillator()
		{
		}

		// Token: 0x0600F3D8 RID: 62424 RVA: 0x00169AD0 File Offset: 0x00167CD0
		public FROscillator(FFOscillator Pitch, FFOscillator Yaw, FFOscillator Roll)
		{
			this.Pitch = Pitch;
			this.Yaw = Yaw;
			this.Roll = Roll;
		}

		// Token: 0x0600F3D9 RID: 62425 RVA: 0x00169AED File Offset: 0x00167CED
		protected override IntPtr GetUStructPtr()
		{
			return FROscillator.StaticStruct();
		}

		// Token: 0x0600F3DA RID: 62426 RVA: 0x00169AF9 File Offset: 0x00167CF9
		[NullableContext(2)]
		public FROscillator(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600F3DB RID: 62427 RVA: 0x00169B03 File Offset: 0x00167D03
		public FROscillator(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600F3DC RID: 62428 RVA: 0x00169B0E File Offset: 0x00167D0E
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FROscillator(Pointer, false, true);
		}

		// Token: 0x0600F3DD RID: 62429 RVA: 0x00169B18 File Offset: 0x00167D18
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FROscillator(Pointer, MemoryOwner);
		}

		// Token: 0x04008426 RID: 33830
		public const string __ObjectPath = "/Script/Engine.ROscillator";

		// Token: 0x04008427 RID: 33831
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04008428 RID: 33832
		internal static int __PropertyOffset_Pitch;

		// Token: 0x04008429 RID: 33833
		[Nullable(2)]
		private FFOscillator _Pitch;

		// Token: 0x0400842A RID: 33834
		internal static int __PropertyOffset_Yaw;

		// Token: 0x0400842B RID: 33835
		[Nullable(2)]
		private FFOscillator _Yaw;

		// Token: 0x0400842C RID: 33836
		internal static int __PropertyOffset_Roll;

		// Token: 0x0400842D RID: 33837
		[Nullable(2)]
		private FFOscillator _Roll;
	}
}
