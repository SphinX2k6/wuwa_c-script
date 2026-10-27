using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001065 RID: 4197
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.RawCurveTracks")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 48)]
	public class FRawCurveTracks : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600EED4 RID: 61140 RVA: 0x0016248B File Offset: 0x0016068B
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRawCurveTracks._ScriptStructPtr != 0) ? FRawCurveTracks._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.RawCurveTracks", ref FRawCurveTracks._ScriptStructPtr);
		}

		// Token: 0x170039CF RID: 14799
		// (get) Token: 0x0600EED5 RID: 61141 RVA: 0x001624B0 File Offset: 0x001606B0
		// (set) Token: 0x0600EED6 RID: 61142 RVA: 0x001624F3 File Offset: 0x001606F3
		public TArray<FFloatCurve> FloatCurves
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FFloatCurve> result;
				if ((result = this._FloatCurves) == null)
				{
					result = (this._FloatCurves = new TArray<FFloatCurve>(base.NativePtr + (IntPtr)FRawCurveTracks.__PropertyOffset_FloatCurves, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.FloatCurves.CopyAssign(value);
			}
		}

		// Token: 0x0600EED7 RID: 61143 RVA: 0x00162501 File Offset: 0x00160701
		public FRawCurveTracks()
		{
		}

		// Token: 0x0600EED8 RID: 61144 RVA: 0x00162509 File Offset: 0x00160709
		public FRawCurveTracks(TArray<FFloatCurve> FloatCurves, TArray<FVectorCurve> VectorCurves, TArray<FTransformCurve> TransformCurves)
		{
			this.FloatCurves = FloatCurves;
		}

		// Token: 0x0600EED9 RID: 61145 RVA: 0x00162518 File Offset: 0x00160718
		protected override IntPtr GetUStructPtr()
		{
			return FRawCurveTracks.StaticStruct();
		}

		// Token: 0x0600EEDA RID: 61146 RVA: 0x00162524 File Offset: 0x00160724
		[NullableContext(2)]
		public FRawCurveTracks(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600EEDB RID: 61147 RVA: 0x0016252E File Offset: 0x0016072E
		public FRawCurveTracks(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600EEDC RID: 61148 RVA: 0x00162539 File Offset: 0x00160739
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRawCurveTracks(Pointer, false, true);
		}

		// Token: 0x0600EEDD RID: 61149 RVA: 0x00162543 File Offset: 0x00160743
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRawCurveTracks(Pointer, MemoryOwner);
		}

		// Token: 0x04008145 RID: 33093
		public const string __ObjectPath = "/Script/Engine.RawCurveTracks";

		// Token: 0x04008146 RID: 33094
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04008147 RID: 33095
		internal static int __PropertyOffset_FloatCurves;

		// Token: 0x04008148 RID: 33096
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FFloatCurve> _FloatCurves;
	}
}
