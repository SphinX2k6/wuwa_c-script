using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000288 RID: 648
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.SplineCurves")]
	[UnrealStructLayout(112, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 112)]
	public class FSplineCurves : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06004706 RID: 18182 RVA: 0x000639BE File Offset: 0x00061BBE
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FSplineCurves._ScriptStructPtr != 0) ? FSplineCurves._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.SplineCurves", ref FSplineCurves._ScriptStructPtr);
		}

		// Token: 0x17000D14 RID: 3348
		// (get) Token: 0x06004707 RID: 18183 RVA: 0x000639E4 File Offset: 0x00061BE4
		// (set) Token: 0x06004708 RID: 18184 RVA: 0x00063A27 File Offset: 0x00061C27
		public FInterpCurveVector Position
		{
			get
			{
				base.FastCheckIsValid();
				FInterpCurveVector result;
				if ((result = this._Position) == null)
				{
					result = (this._Position = new FInterpCurveVector(base.NativePtr + (IntPtr)FSplineCurves.__PropertyOffset_Position, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FInterpCurveVector.StaticStruct(), base.NativePtr + (IntPtr)FSplineCurves.__PropertyOffset_Position, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17000D15 RID: 3349
		// (get) Token: 0x06004709 RID: 18185 RVA: 0x00063A48 File Offset: 0x00061C48
		// (set) Token: 0x0600470A RID: 18186 RVA: 0x00063A8B File Offset: 0x00061C8B
		public FInterpCurveQuat Rotation
		{
			get
			{
				base.FastCheckIsValid();
				FInterpCurveQuat result;
				if ((result = this._Rotation) == null)
				{
					result = (this._Rotation = new FInterpCurveQuat(base.NativePtr + (IntPtr)FSplineCurves.__PropertyOffset_Rotation, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FInterpCurveQuat.StaticStruct(), base.NativePtr + (IntPtr)FSplineCurves.__PropertyOffset_Rotation, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17000D16 RID: 3350
		// (get) Token: 0x0600470B RID: 18187 RVA: 0x00063AAC File Offset: 0x00061CAC
		// (set) Token: 0x0600470C RID: 18188 RVA: 0x00063AEF File Offset: 0x00061CEF
		public FInterpCurveVector Scale
		{
			get
			{
				base.FastCheckIsValid();
				FInterpCurveVector result;
				if ((result = this._Scale) == null)
				{
					result = (this._Scale = new FInterpCurveVector(base.NativePtr + (IntPtr)FSplineCurves.__PropertyOffset_Scale, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FInterpCurveVector.StaticStruct(), base.NativePtr + (IntPtr)FSplineCurves.__PropertyOffset_Scale, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17000D17 RID: 3351
		// (get) Token: 0x0600470D RID: 18189 RVA: 0x00063B10 File Offset: 0x00061D10
		// (set) Token: 0x0600470E RID: 18190 RVA: 0x00063B53 File Offset: 0x00061D53
		public FInterpCurveFloat ReparamTable
		{
			get
			{
				base.FastCheckIsValid();
				FInterpCurveFloat result;
				if ((result = this._ReparamTable) == null)
				{
					result = (this._ReparamTable = new FInterpCurveFloat(base.NativePtr + (IntPtr)FSplineCurves.__PropertyOffset_ReparamTable, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FInterpCurveFloat.StaticStruct(), base.NativePtr + (IntPtr)FSplineCurves.__PropertyOffset_ReparamTable, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17000D18 RID: 3352
		// (get) Token: 0x0600470F RID: 18191 RVA: 0x00063B74 File Offset: 0x00061D74
		// (set) Token: 0x06004710 RID: 18192 RVA: 0x00063B84 File Offset: 0x00061D84
		public unsafe uint Version
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSplineCurves.__PropertyOffset_Version);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSplineCurves.__PropertyOffset_Version) = (int)value;
			}
		}

		// Token: 0x06004711 RID: 18193 RVA: 0x00063B95 File Offset: 0x00061D95
		public FSplineCurves()
		{
		}

		// Token: 0x06004712 RID: 18194 RVA: 0x00063B9D File Offset: 0x00061D9D
		protected override IntPtr GetUStructPtr()
		{
			return FSplineCurves.StaticStruct();
		}

		// Token: 0x06004713 RID: 18195 RVA: 0x00063BA9 File Offset: 0x00061DA9
		[NullableContext(2)]
		public FSplineCurves(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06004714 RID: 18196 RVA: 0x00063BB3 File Offset: 0x00061DB3
		public FSplineCurves(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06004715 RID: 18197 RVA: 0x00063BBE File Offset: 0x00061DBE
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FSplineCurves(Pointer, false, true);
		}

		// Token: 0x06004716 RID: 18198 RVA: 0x00063BC8 File Offset: 0x00061DC8
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FSplineCurves(Pointer, MemoryOwner);
		}

		// Token: 0x04001B5B RID: 7003
		public const string __ObjectPath = "/Script/Engine.SplineCurves";

		// Token: 0x04001B5C RID: 7004
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04001B5D RID: 7005
		internal static int __PropertyOffset_Position;

		// Token: 0x04001B5E RID: 7006
		[Nullable(2)]
		private FInterpCurveVector _Position;

		// Token: 0x04001B5F RID: 7007
		internal static int __PropertyOffset_Rotation;

		// Token: 0x04001B60 RID: 7008
		[Nullable(2)]
		private FInterpCurveQuat _Rotation;

		// Token: 0x04001B61 RID: 7009
		internal static int __PropertyOffset_Scale;

		// Token: 0x04001B62 RID: 7010
		[Nullable(2)]
		private FInterpCurveVector _Scale;

		// Token: 0x04001B63 RID: 7011
		internal static int __PropertyOffset_ReparamTable;

		// Token: 0x04001B64 RID: 7012
		[Nullable(2)]
		private FInterpCurveFloat _ReparamTable;

		// Token: 0x04001B65 RID: 7013
		internal static int __PropertyOffset_Version;
	}
}
