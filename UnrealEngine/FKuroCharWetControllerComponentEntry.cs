using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001AC7 RID: 6855
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroCharWetControllerComponentEntry")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FKuroCharWetControllerComponentEntry : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601979B RID: 104347 RVA: 0x0025A555 File Offset: 0x00258755
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroCharWetControllerComponentEntry._ScriptStructPtr != 0) ? FKuroCharWetControllerComponentEntry._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroRenderingRuntimeBPPlugin.KuroCharWetControllerComponentEntry", ref FKuroCharWetControllerComponentEntry._ScriptStructPtr);
		}

		// Token: 0x1700658E RID: 25998
		// (get) Token: 0x0601979C RID: 104348 RVA: 0x0025A579 File Offset: 0x00258779
		// (set) Token: 0x0601979D RID: 104349 RVA: 0x0025A58D File Offset: 0x0025878D
		public unsafe UKuroMaterialControllerDataAsset DataAsset
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroMaterialControllerDataAsset>(base.NativePtr / (IntPtr)sizeof(void*) + FKuroCharWetControllerComponentEntry.__PropertyOffset_DataAsset);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FKuroCharWetControllerComponentEntry.__PropertyOffset_DataAsset, value);
			}
		}

		// Token: 0x1700658F RID: 25999
		// (get) Token: 0x0601979E RID: 104350 RVA: 0x0025A5A2 File Offset: 0x002587A2
		// (set) Token: 0x0601979F RID: 104351 RVA: 0x0025A5B6 File Offset: 0x002587B6
		public unsafe UKuroMaterialControllerDataAsset LastFrameDataAsset
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroMaterialControllerDataAsset>(base.NativePtr / (IntPtr)sizeof(void*) + FKuroCharWetControllerComponentEntry.__PropertyOffset_LastFrameDataAsset);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FKuroCharWetControllerComponentEntry.__PropertyOffset_LastFrameDataAsset, value);
			}
		}

		// Token: 0x060197A0 RID: 104352 RVA: 0x0025A5CB File Offset: 0x002587CB
		public FKuroCharWetControllerComponentEntry()
		{
		}

		// Token: 0x060197A1 RID: 104353 RVA: 0x0025A5D3 File Offset: 0x002587D3
		[NullableContext(1)]
		public FKuroCharWetControllerComponentEntry(UKuroMaterialControllerDataAsset DataAsset, UKuroMaterialControllerDataAsset LastFrameDataAsset)
		{
			this.DataAsset = DataAsset;
			this.LastFrameDataAsset = LastFrameDataAsset;
		}

		// Token: 0x060197A2 RID: 104354 RVA: 0x0025A5E9 File Offset: 0x002587E9
		protected override IntPtr GetUStructPtr()
		{
			return FKuroCharWetControllerComponentEntry.StaticStruct();
		}

		// Token: 0x060197A3 RID: 104355 RVA: 0x0025A5F5 File Offset: 0x002587F5
		public FKuroCharWetControllerComponentEntry(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060197A4 RID: 104356 RVA: 0x0025A5FF File Offset: 0x002587FF
		public FKuroCharWetControllerComponentEntry(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060197A5 RID: 104357 RVA: 0x0025A60A File Offset: 0x0025880A
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroCharWetControllerComponentEntry(Pointer, false, true);
		}

		// Token: 0x060197A6 RID: 104358 RVA: 0x0025A614 File Offset: 0x00258814
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroCharWetControllerComponentEntry(Pointer, MemoryOwner);
		}

		// Token: 0x0400DDD8 RID: 56792
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroCharWetControllerComponentEntry";

		// Token: 0x0400DDD9 RID: 56793
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400DDDA RID: 56794
		internal static int __PropertyOffset_DataAsset;

		// Token: 0x0400DDDB RID: 56795
		internal static int __PropertyOffset_LastFrameDataAsset;
	}
}
