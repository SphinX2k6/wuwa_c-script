using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000C86 RID: 3206
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.InterpLookupTrack")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FInterpLookupTrack : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600A2AF RID: 41647 RVA: 0x000E7032 File Offset: 0x000E5232
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FInterpLookupTrack._ScriptStructPtr != 0) ? FInterpLookupTrack._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.InterpLookupTrack", ref FInterpLookupTrack._ScriptStructPtr);
		}

		// Token: 0x170026B5 RID: 9909
		// (get) Token: 0x0600A2B0 RID: 41648 RVA: 0x000E7058 File Offset: 0x000E5258
		// (set) Token: 0x0600A2B1 RID: 41649 RVA: 0x000E709B File Offset: 0x000E529B
		public TArray<FInterpLookupPoint> Points
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FInterpLookupPoint> result;
				if ((result = this._Points) == null)
				{
					result = (this._Points = new TArray<FInterpLookupPoint>(base.NativePtr + (IntPtr)FInterpLookupTrack.__PropertyOffset_Points, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Points.CopyAssign(value);
			}
		}

		// Token: 0x0600A2B2 RID: 41650 RVA: 0x000E70A9 File Offset: 0x000E52A9
		public FInterpLookupTrack()
		{
		}

		// Token: 0x0600A2B3 RID: 41651 RVA: 0x000E70B1 File Offset: 0x000E52B1
		public FInterpLookupTrack(TArray<FInterpLookupPoint> Points)
		{
			this.Points = Points;
		}

		// Token: 0x0600A2B4 RID: 41652 RVA: 0x000E70C0 File Offset: 0x000E52C0
		protected override IntPtr GetUStructPtr()
		{
			return FInterpLookupTrack.StaticStruct();
		}

		// Token: 0x0600A2B5 RID: 41653 RVA: 0x000E70CC File Offset: 0x000E52CC
		[NullableContext(2)]
		public FInterpLookupTrack(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600A2B6 RID: 41654 RVA: 0x000E70D6 File Offset: 0x000E52D6
		public FInterpLookupTrack(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600A2B7 RID: 41655 RVA: 0x000E70E1 File Offset: 0x000E52E1
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FInterpLookupTrack(Pointer, false, true);
		}

		// Token: 0x0600A2B8 RID: 41656 RVA: 0x000E70EB File Offset: 0x000E52EB
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FInterpLookupTrack(Pointer, MemoryOwner);
		}

		// Token: 0x04005947 RID: 22855
		public const string __ObjectPath = "/Script/Engine.InterpLookupTrack";

		// Token: 0x04005948 RID: 22856
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04005949 RID: 22857
		internal static int __PropertyOffset_Points;

		// Token: 0x0400594A RID: 22858
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FInterpLookupPoint> _Points;
	}
}
