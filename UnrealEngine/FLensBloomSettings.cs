using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000D20 RID: 3360
	[UnrealObjectPath("/Script/Engine.LensBloomSettings")]
	[UnrealStructLayout(136, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 136)]
	public class FLensBloomSettings : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600B41C RID: 46108 RVA: 0x00100D3E File Offset: 0x000FEF3E
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FLensBloomSettings._ScriptStructPtr != 0) ? FLensBloomSettings._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.LensBloomSettings", ref FLensBloomSettings._ScriptStructPtr);
		}

		// Token: 0x1700292D RID: 10541
		// (get) Token: 0x0600B41D RID: 46109 RVA: 0x00100D64 File Offset: 0x000FEF64
		// (set) Token: 0x0600B41E RID: 46110 RVA: 0x00100DA7 File Offset: 0x000FEFA7
		[Nullable(1)]
		public FGaussianSumBloomSettings GaussianSum
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FGaussianSumBloomSettings result;
				if ((result = this._GaussianSum) == null)
				{
					result = (this._GaussianSum = new FGaussianSumBloomSettings(base.NativePtr + (IntPtr)FLensBloomSettings.__PropertyOffset_GaussianSum, base.MemoryOwner ?? this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGaussianSumBloomSettings.StaticStruct(), base.NativePtr + (IntPtr)FLensBloomSettings.__PropertyOffset_GaussianSum, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700292E RID: 10542
		// (get) Token: 0x0600B41F RID: 46111 RVA: 0x00100DC8 File Offset: 0x000FEFC8
		// (set) Token: 0x0600B420 RID: 46112 RVA: 0x00100DDC File Offset: 0x000FEFDC
		public unsafe TEnumAsByte<EBloomMethod> Method
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLensBloomSettings.__PropertyOffset_Method);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLensBloomSettings.__PropertyOffset_Method) = value;
			}
		}

		// Token: 0x0600B421 RID: 46113 RVA: 0x00100DF1 File Offset: 0x000FEFF1
		public FLensBloomSettings()
		{
		}

		// Token: 0x0600B422 RID: 46114 RVA: 0x00100DF9 File Offset: 0x000FEFF9
		public FLensBloomSettings([Nullable(1)] FGaussianSumBloomSettings GaussianSum, TEnumAsByte<EBloomMethod> Method)
		{
			this.GaussianSum = GaussianSum;
			this.Method = Method;
		}

		// Token: 0x0600B423 RID: 46115 RVA: 0x00100E0F File Offset: 0x000FF00F
		protected override IntPtr GetUStructPtr()
		{
			return FLensBloomSettings.StaticStruct();
		}

		// Token: 0x0600B424 RID: 46116 RVA: 0x00100E1B File Offset: 0x000FF01B
		[NullableContext(2)]
		public FLensBloomSettings(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600B425 RID: 46117 RVA: 0x00100E25 File Offset: 0x000FF025
		public FLensBloomSettings(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600B426 RID: 46118 RVA: 0x00100E30 File Offset: 0x000FF030
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FLensBloomSettings(Pointer, false, true);
		}

		// Token: 0x0600B427 RID: 46119 RVA: 0x00100E3A File Offset: 0x000FF03A
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FLensBloomSettings(Pointer, MemoryOwner);
		}

		// Token: 0x04005EA7 RID: 24231
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.LensBloomSettings";

		// Token: 0x04005EA8 RID: 24232
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04005EA9 RID: 24233
		internal static int __PropertyOffset_GaussianSum;

		// Token: 0x04005EAA RID: 24234
		[Nullable(2)]
		private FGaussianSumBloomSettings _GaussianSum;

		// Token: 0x04005EAB RID: 24235
		internal static int __PropertyOffset_Method;
	}
}
