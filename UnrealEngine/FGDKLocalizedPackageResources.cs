using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001403 RID: 5123
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/GDKPlatformEditor.GDKLocalizedPackageResources")]
	[UnrealStructLayout(72, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 72)]
	public class FGDKLocalizedPackageResources : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06012AF6 RID: 76534 RVA: 0x001B81BA File Offset: 0x001B63BA
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FGDKLocalizedPackageResources._ScriptStructPtr != 0) ? FGDKLocalizedPackageResources._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/GDKPlatformEditor.GDKLocalizedPackageResources", ref FGDKLocalizedPackageResources._ScriptStructPtr);
		}

		// Token: 0x1700485A RID: 18522
		// (get) Token: 0x06012AF7 RID: 76535 RVA: 0x001B81DE File Offset: 0x001B63DE
		// (set) Token: 0x06012AF8 RID: 76536 RVA: 0x001B81F2 File Offset: 0x001B63F2
		public unsafe string StageId
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FGDKLocalizedPackageResources.__PropertyOffset_StageId)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FGDKLocalizedPackageResources.__PropertyOffset_StageId)), value);
			}
		}

		// Token: 0x1700485B RID: 18523
		// (get) Token: 0x06012AF9 RID: 76537 RVA: 0x001B8207 File Offset: 0x001B6407
		// (set) Token: 0x06012AFA RID: 76538 RVA: 0x001B821B File Offset: 0x001B641B
		public unsafe string CultureId
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FGDKLocalizedPackageResources.__PropertyOffset_CultureId)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FGDKLocalizedPackageResources.__PropertyOffset_CultureId)), value);
			}
		}

		// Token: 0x1700485C RID: 18524
		// (get) Token: 0x06012AFB RID: 76539 RVA: 0x001B8230 File Offset: 0x001B6430
		// (set) Token: 0x06012AFC RID: 76540 RVA: 0x001B8273 File Offset: 0x001B6473
		public FGDKPackageStringResources CultureStringResources
		{
			get
			{
				base.FastCheckIsValid();
				FGDKPackageStringResources result;
				if ((result = this._CultureStringResources) == null)
				{
					result = (this._CultureStringResources = new FGDKPackageStringResources(base.NativePtr + (IntPtr)FGDKLocalizedPackageResources.__PropertyOffset_CultureStringResources, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FGDKPackageStringResources.StaticStruct(), base.NativePtr + (IntPtr)FGDKLocalizedPackageResources.__PropertyOffset_CultureStringResources, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700485D RID: 18525
		// (get) Token: 0x06012AFD RID: 76541 RVA: 0x001B8294 File Offset: 0x001B6494
		// (set) Token: 0x06012AFE RID: 76542 RVA: 0x001B82A8 File Offset: 0x001B64A8
		public unsafe FGDKPackageImageResources CultureImageResources
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FGDKLocalizedPackageResources.__PropertyOffset_CultureImageResources);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FGDKLocalizedPackageResources.__PropertyOffset_CultureImageResources) = value;
			}
		}

		// Token: 0x06012AFF RID: 76543 RVA: 0x001B82BD File Offset: 0x001B64BD
		public FGDKLocalizedPackageResources()
		{
		}

		// Token: 0x06012B00 RID: 76544 RVA: 0x001B82C5 File Offset: 0x001B64C5
		public FGDKLocalizedPackageResources(string StageId, string CultureId, FGDKPackageStringResources CultureStringResources, FGDKPackageImageResources CultureImageResources)
		{
			this.StageId = StageId;
			this.CultureId = CultureId;
			this.CultureStringResources = CultureStringResources;
			this.CultureImageResources = CultureImageResources;
		}

		// Token: 0x06012B01 RID: 76545 RVA: 0x001B82EA File Offset: 0x001B64EA
		protected override IntPtr GetUStructPtr()
		{
			return FGDKLocalizedPackageResources.StaticStruct();
		}

		// Token: 0x06012B02 RID: 76546 RVA: 0x001B82F6 File Offset: 0x001B64F6
		[NullableContext(2)]
		public FGDKLocalizedPackageResources(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06012B03 RID: 76547 RVA: 0x001B8300 File Offset: 0x001B6500
		public FGDKLocalizedPackageResources(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06012B04 RID: 76548 RVA: 0x001B830B File Offset: 0x001B650B
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FGDKLocalizedPackageResources(Pointer, false, true);
		}

		// Token: 0x06012B05 RID: 76549 RVA: 0x001B8315 File Offset: 0x001B6515
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FGDKLocalizedPackageResources(Pointer, MemoryOwner);
		}

		// Token: 0x04009FD4 RID: 40916
		public const string __ObjectPath = "/Script/GDKPlatformEditor.GDKLocalizedPackageResources";

		// Token: 0x04009FD5 RID: 40917
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04009FD6 RID: 40918
		internal static int __PropertyOffset_StageId;

		// Token: 0x04009FD7 RID: 40919
		internal static int __PropertyOffset_CultureId;

		// Token: 0x04009FD8 RID: 40920
		internal static int __PropertyOffset_CultureStringResources;

		// Token: 0x04009FD9 RID: 40921
		[Nullable(2)]
		private FGDKPackageStringResources _CultureStringResources;

		// Token: 0x04009FDA RID: 40922
		internal static int __PropertyOffset_CultureImageResources;
	}
}
