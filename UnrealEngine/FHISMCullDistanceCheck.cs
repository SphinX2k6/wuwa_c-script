using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000C21 RID: 3105
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.HISMCullDistanceCheck")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FHISMCullDistanceCheck : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06009D61 RID: 40289 RVA: 0x000DFC1F File Offset: 0x000DDE1F
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FHISMCullDistanceCheck._ScriptStructPtr != 0) ? FHISMCullDistanceCheck._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.HISMCullDistanceCheck", ref FHISMCullDistanceCheck._ScriptStructPtr);
		}

		// Token: 0x17002599 RID: 9625
		// (get) Token: 0x06009D62 RID: 40290 RVA: 0x000DFC44 File Offset: 0x000DDE44
		// (set) Token: 0x06009D63 RID: 40291 RVA: 0x000DFC87 File Offset: 0x000DDE87
		public TArray<FHISMDistanceInfo> HISMCullDistanceConfig
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FHISMDistanceInfo> result;
				if ((result = this._HISMCullDistanceConfig) == null)
				{
					result = (this._HISMCullDistanceConfig = new TArray<FHISMDistanceInfo>(base.NativePtr + (IntPtr)FHISMCullDistanceCheck.__PropertyOffset_HISMCullDistanceConfig, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.HISMCullDistanceConfig.CopyAssign(value);
			}
		}

		// Token: 0x06009D64 RID: 40292 RVA: 0x000DFC95 File Offset: 0x000DDE95
		public FHISMCullDistanceCheck()
		{
		}

		// Token: 0x06009D65 RID: 40293 RVA: 0x000DFC9D File Offset: 0x000DDE9D
		public FHISMCullDistanceCheck(TArray<FHISMDistanceInfo> HISMCullDistanceConfig)
		{
			this.HISMCullDistanceConfig = HISMCullDistanceConfig;
		}

		// Token: 0x06009D66 RID: 40294 RVA: 0x000DFCAC File Offset: 0x000DDEAC
		protected override IntPtr GetUStructPtr()
		{
			return FHISMCullDistanceCheck.StaticStruct();
		}

		// Token: 0x06009D67 RID: 40295 RVA: 0x000DFCB8 File Offset: 0x000DDEB8
		[NullableContext(2)]
		public FHISMCullDistanceCheck(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06009D68 RID: 40296 RVA: 0x000DFCC2 File Offset: 0x000DDEC2
		public FHISMCullDistanceCheck(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06009D69 RID: 40297 RVA: 0x000DFCCD File Offset: 0x000DDECD
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FHISMCullDistanceCheck(Pointer, false, true);
		}

		// Token: 0x06009D6A RID: 40298 RVA: 0x000DFCD7 File Offset: 0x000DDED7
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FHISMCullDistanceCheck(Pointer, MemoryOwner);
		}

		// Token: 0x040056D4 RID: 22228
		public const string __ObjectPath = "/Script/Engine.HISMCullDistanceCheck";

		// Token: 0x040056D5 RID: 22229
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040056D6 RID: 22230
		internal static int __PropertyOffset_HISMCullDistanceConfig;

		// Token: 0x040056D7 RID: 22231
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FHISMDistanceInfo> _HISMCullDistanceConfig;
	}
}
