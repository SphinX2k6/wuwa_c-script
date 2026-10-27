using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020010CF RID: 4303
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.ScaleTrack")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class FScaleTrack : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600F583 RID: 62851 RVA: 0x0016BD79 File Offset: 0x00169F79
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FScaleTrack._ScriptStructPtr != 0) ? FScaleTrack._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.ScaleTrack", ref FScaleTrack._ScriptStructPtr);
		}

		// Token: 0x17003BC8 RID: 15304
		// (get) Token: 0x0600F584 RID: 62852 RVA: 0x0016BDA0 File Offset: 0x00169FA0
		// (set) Token: 0x0600F585 RID: 62853 RVA: 0x0016BDE3 File Offset: 0x00169FE3
		public TArray<FVector> ScaleKeys
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FVector> result;
				if ((result = this._ScaleKeys) == null)
				{
					result = (this._ScaleKeys = new TArray<FVector>(base.NativePtr + (IntPtr)FScaleTrack.__PropertyOffset_ScaleKeys, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.ScaleKeys.CopyAssign(value);
			}
		}

		// Token: 0x17003BC9 RID: 15305
		// (get) Token: 0x0600F586 RID: 62854 RVA: 0x0016BDF4 File Offset: 0x00169FF4
		// (set) Token: 0x0600F587 RID: 62855 RVA: 0x0016BE37 File Offset: 0x0016A037
		public TArray<float> Times
		{
			get
			{
				base.FastCheckIsValid();
				TArray<float> result;
				if ((result = this._Times) == null)
				{
					result = (this._Times = new TArray<float>(base.NativePtr + (IntPtr)FScaleTrack.__PropertyOffset_Times, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Times.CopyAssign(value);
			}
		}

		// Token: 0x0600F588 RID: 62856 RVA: 0x0016BE45 File Offset: 0x0016A045
		public FScaleTrack()
		{
		}

		// Token: 0x0600F589 RID: 62857 RVA: 0x0016BE4D File Offset: 0x0016A04D
		public FScaleTrack(TArray<FVector> ScaleKeys, TArray<float> Times)
		{
			this.ScaleKeys = ScaleKeys;
			this.Times = Times;
		}

		// Token: 0x0600F58A RID: 62858 RVA: 0x0016BE63 File Offset: 0x0016A063
		protected override IntPtr GetUStructPtr()
		{
			return FScaleTrack.StaticStruct();
		}

		// Token: 0x0600F58B RID: 62859 RVA: 0x0016BE6F File Offset: 0x0016A06F
		[NullableContext(2)]
		public FScaleTrack(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600F58C RID: 62860 RVA: 0x0016BE79 File Offset: 0x0016A079
		public FScaleTrack(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600F58D RID: 62861 RVA: 0x0016BE84 File Offset: 0x0016A084
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FScaleTrack(Pointer, false, true);
		}

		// Token: 0x0600F58E RID: 62862 RVA: 0x0016BE8E File Offset: 0x0016A08E
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FScaleTrack(Pointer, MemoryOwner);
		}

		// Token: 0x04008500 RID: 34048
		public const string __ObjectPath = "/Script/Engine.ScaleTrack";

		// Token: 0x04008501 RID: 34049
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04008502 RID: 34050
		internal static int __PropertyOffset_ScaleKeys;

		// Token: 0x04008503 RID: 34051
		[Nullable(2)]
		private TArray<FVector> _ScaleKeys;

		// Token: 0x04008504 RID: 34052
		internal static int __PropertyOffset_Times;

		// Token: 0x04008505 RID: 34053
		[Nullable(2)]
		private TArray<float> _Times;
	}
}
