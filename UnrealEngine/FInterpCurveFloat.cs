using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200011B RID: 283
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/CoreUObject.InterpCurveFloat")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FInterpCurveFloat : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06001194 RID: 4500 RVA: 0x0001BD2E File Offset: 0x00019F2E
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FInterpCurveFloat._ScriptStructPtr != 0) ? FInterpCurveFloat._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/CoreUObject.InterpCurveFloat", ref FInterpCurveFloat._ScriptStructPtr);
		}

		// Token: 0x170001B6 RID: 438
		// (get) Token: 0x06001195 RID: 4501 RVA: 0x0001BD54 File Offset: 0x00019F54
		// (set) Token: 0x06001196 RID: 4502 RVA: 0x0001BD97 File Offset: 0x00019F97
		public TArray<FInterpCurvePointFloat> Points
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FInterpCurvePointFloat> result;
				if ((result = this._Points) == null)
				{
					result = (this._Points = new TArray<FInterpCurvePointFloat>(base.NativePtr + (IntPtr)FInterpCurveFloat.__PropertyOffset_Points, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Points.CopyAssign(value);
			}
		}

		// Token: 0x170001B7 RID: 439
		// (get) Token: 0x06001197 RID: 4503 RVA: 0x0001BDA5 File Offset: 0x00019FA5
		// (set) Token: 0x06001198 RID: 4504 RVA: 0x0001BDB5 File Offset: 0x00019FB5
		public unsafe bool bIsLooped
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FInterpCurveFloat.__PropertyOffset_bIsLooped) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FInterpCurveFloat.__PropertyOffset_bIsLooped) = (value ? 1 : 0);
			}
		}

		// Token: 0x170001B8 RID: 440
		// (get) Token: 0x06001199 RID: 4505 RVA: 0x0001BDC6 File Offset: 0x00019FC6
		// (set) Token: 0x0600119A RID: 4506 RVA: 0x0001BDD6 File Offset: 0x00019FD6
		public unsafe float LoopKeyOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FInterpCurveFloat.__PropertyOffset_LoopKeyOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FInterpCurveFloat.__PropertyOffset_LoopKeyOffset) = value;
			}
		}

		// Token: 0x0600119B RID: 4507 RVA: 0x0001BDE7 File Offset: 0x00019FE7
		public FInterpCurveFloat()
		{
		}

		// Token: 0x0600119C RID: 4508 RVA: 0x0001BDEF File Offset: 0x00019FEF
		protected override IntPtr GetUStructPtr()
		{
			return FInterpCurveFloat.StaticStruct();
		}

		// Token: 0x0600119D RID: 4509 RVA: 0x0001BDFB File Offset: 0x00019FFB
		[NullableContext(2)]
		public FInterpCurveFloat(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600119E RID: 4510 RVA: 0x0001BE05 File Offset: 0x0001A005
		public FInterpCurveFloat(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600119F RID: 4511 RVA: 0x0001BE10 File Offset: 0x0001A010
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FInterpCurveFloat(Pointer, false, true);
		}

		// Token: 0x060011A0 RID: 4512 RVA: 0x0001BE1A File Offset: 0x0001A01A
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FInterpCurveFloat(Pointer, MemoryOwner);
		}

		// Token: 0x0400051C RID: 1308
		public const string __ObjectPath = "/Script/CoreUObject.InterpCurveFloat";

		// Token: 0x0400051D RID: 1309
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400051E RID: 1310
		internal static int __PropertyOffset_Points;

		// Token: 0x0400051F RID: 1311
		[Nullable(2)]
		private TArray<FInterpCurvePointFloat> _Points;

		// Token: 0x04000520 RID: 1312
		internal static int __PropertyOffset_bIsLooped;

		// Token: 0x04000521 RID: 1313
		internal static int __PropertyOffset_LoopKeyOffset;
	}
}
