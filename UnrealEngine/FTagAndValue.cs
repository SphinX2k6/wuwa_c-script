using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000361 RID: 865
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AssetRegistry.TagAndValue")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class FTagAndValue : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06003009 RID: 12297 RVA: 0x0004A7BE File Offset: 0x000489BE
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FTagAndValue._ScriptStructPtr != 0) ? FTagAndValue._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/AssetRegistry.TagAndValue", ref FTagAndValue._ScriptStructPtr);
		}

		// Token: 0x17000BE1 RID: 3041
		// (get) Token: 0x0600300A RID: 12298 RVA: 0x0004A7E2 File Offset: 0x000489E2
		// (set) Token: 0x0600300B RID: 12299 RVA: 0x0004A7F6 File Offset: 0x000489F6
		public unsafe FName Tag
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FTagAndValue.__PropertyOffset_Tag);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FTagAndValue.__PropertyOffset_Tag) = value;
			}
		}

		// Token: 0x17000BE2 RID: 3042
		// (get) Token: 0x0600300C RID: 12300 RVA: 0x0004A80B File Offset: 0x00048A0B
		// (set) Token: 0x0600300D RID: 12301 RVA: 0x0004A81F File Offset: 0x00048A1F
		public unsafe string Value
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FTagAndValue.__PropertyOffset_Value)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FTagAndValue.__PropertyOffset_Value)), value);
			}
		}

		// Token: 0x0600300E RID: 12302 RVA: 0x0004A834 File Offset: 0x00048A34
		public FTagAndValue()
		{
		}

		// Token: 0x0600300F RID: 12303 RVA: 0x0004A83C File Offset: 0x00048A3C
		public FTagAndValue(FName Tag, string Value)
		{
			this.Tag = Tag;
			this.Value = Value;
		}

		// Token: 0x06003010 RID: 12304 RVA: 0x0004A852 File Offset: 0x00048A52
		protected override IntPtr GetUStructPtr()
		{
			return FTagAndValue.StaticStruct();
		}

		// Token: 0x06003011 RID: 12305 RVA: 0x0004A85E File Offset: 0x00048A5E
		[NullableContext(2)]
		public FTagAndValue(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06003012 RID: 12306 RVA: 0x0004A868 File Offset: 0x00048A68
		public FTagAndValue(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06003013 RID: 12307 RVA: 0x0004A873 File Offset: 0x00048A73
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FTagAndValue(Pointer, false, true);
		}

		// Token: 0x06003014 RID: 12308 RVA: 0x0004A87D File Offset: 0x00048A7D
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FTagAndValue(Pointer, MemoryOwner);
		}

		// Token: 0x040014DA RID: 5338
		public const string __ObjectPath = "/Script/AssetRegistry.TagAndValue";

		// Token: 0x040014DB RID: 5339
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040014DC RID: 5340
		internal static int __PropertyOffset_Tag;

		// Token: 0x040014DD RID: 5341
		internal static int __PropertyOffset_Value;
	}
}
