using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200107A RID: 4218
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.RegionBound")]
	[UnrealStructLayout(40, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 40)]
	public class FRegionBound : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600F017 RID: 61463 RVA: 0x00163E51 File Offset: 0x00162051
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FRegionBound._ScriptStructPtr != 0) ? FRegionBound._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.RegionBound", ref FRegionBound._ScriptStructPtr);
		}

		// Token: 0x17003A22 RID: 14882
		// (get) Token: 0x0600F018 RID: 61464 RVA: 0x00163E75 File Offset: 0x00162075
		// (set) Token: 0x0600F019 RID: 61465 RVA: 0x00163E89 File Offset: 0x00162089
		public unsafe FBox2D Region
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FRegionBound.__PropertyOffset_Region);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FRegionBound.__PropertyOffset_Region) = value;
			}
		}

		// Token: 0x17003A23 RID: 14883
		// (get) Token: 0x0600F01A RID: 61466 RVA: 0x00163EA0 File Offset: 0x001620A0
		// (set) Token: 0x0600F01B RID: 61467 RVA: 0x00163EE3 File Offset: 0x001620E3
		public TArray<string> LegalAssetPath
		{
			get
			{
				base.FastCheckIsValid();
				TArray<string> result;
				if ((result = this._LegalAssetPath) == null)
				{
					result = (this._LegalAssetPath = new TArray<string>(base.NativePtr + (IntPtr)FRegionBound.__PropertyOffset_LegalAssetPath, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.LegalAssetPath.CopyAssign(value);
			}
		}

		// Token: 0x0600F01C RID: 61468 RVA: 0x00163EF1 File Offset: 0x001620F1
		public FRegionBound()
		{
		}

		// Token: 0x0600F01D RID: 61469 RVA: 0x00163EF9 File Offset: 0x001620F9
		public FRegionBound(FBox2D Region, TArray<string> LegalAssetPath)
		{
			this.Region = Region;
			this.LegalAssetPath = LegalAssetPath;
		}

		// Token: 0x0600F01E RID: 61470 RVA: 0x00163F0F File Offset: 0x0016210F
		protected override IntPtr GetUStructPtr()
		{
			return FRegionBound.StaticStruct();
		}

		// Token: 0x0600F01F RID: 61471 RVA: 0x00163F1B File Offset: 0x0016211B
		[NullableContext(2)]
		public FRegionBound(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600F020 RID: 61472 RVA: 0x00163F25 File Offset: 0x00162125
		public FRegionBound(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600F021 RID: 61473 RVA: 0x00163F30 File Offset: 0x00162130
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FRegionBound(Pointer, false, true);
		}

		// Token: 0x0600F022 RID: 61474 RVA: 0x00163F3A File Offset: 0x0016213A
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FRegionBound(Pointer, MemoryOwner);
		}

		// Token: 0x040081DE RID: 33246
		public const string __ObjectPath = "/Script/Engine.RegionBound";

		// Token: 0x040081DF RID: 33247
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040081E0 RID: 33248
		internal static int __PropertyOffset_Region;

		// Token: 0x040081E1 RID: 33249
		internal static int __PropertyOffset_LegalAssetPath;

		// Token: 0x040081E2 RID: 33250
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<string> _LegalAssetPath;
	}
}
