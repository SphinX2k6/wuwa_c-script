using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020020EE RID: 8430
	[UnrealObjectPath("/Script/LGUI.MultiTemplateScrollViewGridPoolInfo")]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 24)]
	public class FMultiTemplateScrollViewGridPoolInfo : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601FBD7 RID: 130007 RVA: 0x002F31DA File Offset: 0x002F13DA
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FMultiTemplateScrollViewGridPoolInfo._ScriptStructPtr != 0) ? FMultiTemplateScrollViewGridPoolInfo._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/LGUI.MultiTemplateScrollViewGridPoolInfo", ref FMultiTemplateScrollViewGridPoolInfo._ScriptStructPtr);
		}

		// Token: 0x17007CF2 RID: 31986
		// (get) Token: 0x0601FBD8 RID: 130008 RVA: 0x002F3200 File Offset: 0x002F1400
		// (set) Token: 0x0601FBD9 RID: 130009 RVA: 0x002F3243 File Offset: 0x002F1443
		[Nullable(new byte[]
		{
			1,
			0,
			1
		})]
		public TArray<TWeakObjectPtr<AUIBaseActor>> ItemArray
		{
			[return: Nullable(new byte[]
			{
				1,
				0,
				1
			})]
			get
			{
				base.FastCheckIsValid();
				TArray<TWeakObjectPtr<AUIBaseActor>> result;
				if ((result = this._ItemArray) == null)
				{
					result = (this._ItemArray = new TArray<TWeakObjectPtr<AUIBaseActor>>(base.NativePtr + (IntPtr)FMultiTemplateScrollViewGridPoolInfo.__PropertyOffset_ItemArray, base.MemoryOwner ?? this));
				}
				return result;
			}
			[param: Nullable(new byte[]
			{
				1,
				0,
				1
			})]
			set
			{
				this.ItemArray.CopyAssign(value);
			}
		}

		// Token: 0x0601FBDA RID: 130010 RVA: 0x002F3251 File Offset: 0x002F1451
		public FMultiTemplateScrollViewGridPoolInfo()
		{
		}

		// Token: 0x0601FBDB RID: 130011 RVA: 0x002F3259 File Offset: 0x002F1459
		public FMultiTemplateScrollViewGridPoolInfo([Nullable(new byte[]
		{
			1,
			0,
			1
		})] TArray<TWeakObjectPtr<AUIBaseActor>> ItemArray)
		{
			this.ItemArray = ItemArray;
		}

		// Token: 0x0601FBDC RID: 130012 RVA: 0x002F3268 File Offset: 0x002F1468
		protected override IntPtr GetUStructPtr()
		{
			return FMultiTemplateScrollViewGridPoolInfo.StaticStruct();
		}

		// Token: 0x0601FBDD RID: 130013 RVA: 0x002F3274 File Offset: 0x002F1474
		[NullableContext(2)]
		public FMultiTemplateScrollViewGridPoolInfo(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601FBDE RID: 130014 RVA: 0x002F327E File Offset: 0x002F147E
		public FMultiTemplateScrollViewGridPoolInfo(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601FBDF RID: 130015 RVA: 0x002F3289 File Offset: 0x002F1489
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FMultiTemplateScrollViewGridPoolInfo(Pointer, false, true);
		}

		// Token: 0x0601FBE0 RID: 130016 RVA: 0x002F3293 File Offset: 0x002F1493
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FMultiTemplateScrollViewGridPoolInfo(Pointer, MemoryOwner);
		}

		// Token: 0x040111C3 RID: 70083
		[Nullable(1)]
		public const string __ObjectPath = "/Script/LGUI.MultiTemplateScrollViewGridPoolInfo";

		// Token: 0x040111C4 RID: 70084
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040111C5 RID: 70085
		internal static int __PropertyOffset_ItemArray;

		// Token: 0x040111C6 RID: 70086
		[Nullable(new byte[]
		{
			2,
			0,
			1
		})]
		private TArray<TWeakObjectPtr<AUIBaseActor>> _ItemArray;
	}
}
