using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002218 RID: 8728
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/LiveLinkInterface.LiveLinkSourcePreset")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 48)]
	public class FLiveLinkSourcePreset : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060213E2 RID: 136162 RVA: 0x00310135 File Offset: 0x0030E335
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FLiveLinkSourcePreset._ScriptStructPtr != 0) ? FLiveLinkSourcePreset._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/LiveLinkInterface.LiveLinkSourcePreset", ref FLiveLinkSourcePreset._ScriptStructPtr);
		}

		// Token: 0x170081C2 RID: 33218
		// (get) Token: 0x060213E3 RID: 136163 RVA: 0x00310159 File Offset: 0x0030E359
		// (set) Token: 0x060213E4 RID: 136164 RVA: 0x0031016D File Offset: 0x0030E36D
		public unsafe FGuid Guid
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FLiveLinkSourcePreset.__PropertyOffset_Guid);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FLiveLinkSourcePreset.__PropertyOffset_Guid) = value;
			}
		}

		// Token: 0x170081C3 RID: 33219
		// (get) Token: 0x060213E5 RID: 136165 RVA: 0x00310182 File Offset: 0x0030E382
		// (set) Token: 0x060213E6 RID: 136166 RVA: 0x00310196 File Offset: 0x0030E396
		[Nullable(2)]
		public unsafe ULiveLinkSourceSettings Settings
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<ULiveLinkSourceSettings>(base.NativePtr / (IntPtr)sizeof(void*) + FLiveLinkSourcePreset.__PropertyOffset_Settings);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FLiveLinkSourcePreset.__PropertyOffset_Settings, value);
			}
		}

		// Token: 0x170081C4 RID: 33220
		// (get) Token: 0x060213E7 RID: 136167 RVA: 0x003101AC File Offset: 0x0030E3AC
		// (set) Token: 0x060213E8 RID: 136168 RVA: 0x003101EF File Offset: 0x0030E3EF
		public unsafe FText SourceType
		{
			get
			{
				base.FastCheckIsValid();
				FText result;
				if ((result = this._SourceType) == null)
				{
					result = (this._SourceType = new FText(base.NativePtr + (IntPtr)FLiveLinkSourcePreset.__PropertyOffset_SourceType, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				FText.NativeCopy((void*)(base.NativePtr + (byte*)((IntPtr)FLiveLinkSourcePreset.__PropertyOffset_SourceType)), value.NativePtr, 1);
			}
		}

		// Token: 0x060213E9 RID: 136169 RVA: 0x0031020A File Offset: 0x0030E40A
		public FLiveLinkSourcePreset()
		{
		}

		// Token: 0x060213EA RID: 136170 RVA: 0x00310212 File Offset: 0x0030E412
		public FLiveLinkSourcePreset(FGuid Guid, ULiveLinkSourceSettings Settings, FText SourceType)
		{
			this.Guid = Guid;
			this.Settings = Settings;
			this.SourceType = SourceType;
		}

		// Token: 0x060213EB RID: 136171 RVA: 0x0031022F File Offset: 0x0030E42F
		protected override IntPtr GetUStructPtr()
		{
			return FLiveLinkSourcePreset.StaticStruct();
		}

		// Token: 0x060213EC RID: 136172 RVA: 0x0031023B File Offset: 0x0030E43B
		[NullableContext(2)]
		public FLiveLinkSourcePreset(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060213ED RID: 136173 RVA: 0x00310245 File Offset: 0x0030E445
		public FLiveLinkSourcePreset(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060213EE RID: 136174 RVA: 0x00310250 File Offset: 0x0030E450
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FLiveLinkSourcePreset(Pointer, false, true);
		}

		// Token: 0x060213EF RID: 136175 RVA: 0x0031025A File Offset: 0x0030E45A
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FLiveLinkSourcePreset(Pointer, MemoryOwner);
		}

		// Token: 0x04011BB6 RID: 72630
		public const string __ObjectPath = "/Script/LiveLinkInterface.LiveLinkSourcePreset";

		// Token: 0x04011BB7 RID: 72631
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04011BB8 RID: 72632
		internal static int __PropertyOffset_Guid;

		// Token: 0x04011BB9 RID: 72633
		internal static int __PropertyOffset_Settings;

		// Token: 0x04011BBA RID: 72634
		internal static int __PropertyOffset_SourceType;

		// Token: 0x04011BBB RID: 72635
		[Nullable(2)]
		private FText _SourceType;
	}
}
