using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200106E RID: 4206
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.RBFDriveSetting")]
	[UnrealStructLayout(40, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 40)]
	public class FRBFDriveSetting : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600EF4E RID: 61262 RVA: 0x00162E3E File Offset: 0x0016103E
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRBFDriveSetting._ScriptStructPtr != 0) ? FRBFDriveSetting._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.RBFDriveSetting", ref FRBFDriveSetting._ScriptStructPtr);
		}

		// Token: 0x170039EB RID: 14827
		// (get) Token: 0x0600EF4F RID: 61263 RVA: 0x00162E64 File Offset: 0x00161064
		// (set) Token: 0x0600EF50 RID: 61264 RVA: 0x00162EA7 File Offset: 0x001610A7
		public TArray<FRBFDriverPose> DriverPoses
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FRBFDriverPose> result;
				if ((result = this._DriverPoses) == null)
				{
					result = (this._DriverPoses = new TArray<FRBFDriverPose>(base.NativePtr + (IntPtr)FRBFDriveSetting.__PropertyOffset_DriverPoses, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.DriverPoses.CopyAssign(value);
			}
		}

		// Token: 0x170039EC RID: 14828
		// (get) Token: 0x0600EF51 RID: 61265 RVA: 0x00162EB8 File Offset: 0x001610B8
		// (set) Token: 0x0600EF52 RID: 61266 RVA: 0x00162EFB File Offset: 0x001610FB
		public TArray<FRBFDrivenWeight> DrivenWeights
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FRBFDrivenWeight> result;
				if ((result = this._DrivenWeights) == null)
				{
					result = (this._DrivenWeights = new TArray<FRBFDrivenWeight>(base.NativePtr + (IntPtr)FRBFDriveSetting.__PropertyOffset_DrivenWeights, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.DrivenWeights.CopyAssign(value);
			}
		}

		// Token: 0x0600EF53 RID: 61267 RVA: 0x00162F09 File Offset: 0x00161109
		public FRBFDriveSetting()
		{
		}

		// Token: 0x0600EF54 RID: 61268 RVA: 0x00162F11 File Offset: 0x00161111
		public FRBFDriveSetting(TArray<FRBFDriverPose> DriverPoses, TArray<FRBFDrivenWeight> DrivenWeights)
		{
			this.DriverPoses = DriverPoses;
			this.DrivenWeights = DrivenWeights;
		}

		// Token: 0x0600EF55 RID: 61269 RVA: 0x00162F27 File Offset: 0x00161127
		protected override IntPtr GetUStructPtr()
		{
			return FRBFDriveSetting.StaticStruct();
		}

		// Token: 0x0600EF56 RID: 61270 RVA: 0x00162F33 File Offset: 0x00161133
		[NullableContext(2)]
		public FRBFDriveSetting(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600EF57 RID: 61271 RVA: 0x00162F3D File Offset: 0x0016113D
		public FRBFDriveSetting(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600EF58 RID: 61272 RVA: 0x00162F48 File Offset: 0x00161148
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRBFDriveSetting(Pointer, false, true);
		}

		// Token: 0x0600EF59 RID: 61273 RVA: 0x00162F52 File Offset: 0x00161152
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRBFDriveSetting(Pointer, MemoryOwner);
		}

		// Token: 0x0400817D RID: 33149
		public const string __ObjectPath = "/Script/Engine.RBFDriveSetting";

		// Token: 0x0400817E RID: 33150
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400817F RID: 33151
		internal static int __PropertyOffset_DriverPoses;

		// Token: 0x04008180 RID: 33152
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FRBFDriverPose> _DriverPoses;

		// Token: 0x04008181 RID: 33153
		internal static int __PropertyOffset_DrivenWeights;

		// Token: 0x04008182 RID: 33154
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FRBFDrivenWeight> _DrivenWeights;
	}
}
