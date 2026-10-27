using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000CEC RID: 3308
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.KuroFoliageDetailCheckData")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 48)]
	public class FKuroFoliageDetailCheckData : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600AF87 RID: 44935 RVA: 0x000F8F4C File Offset: 0x000F714C
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroFoliageDetailCheckData._ScriptStructPtr != 0) ? FKuroFoliageDetailCheckData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.KuroFoliageDetailCheckData", ref FKuroFoliageDetailCheckData._ScriptStructPtr);
		}

		// Token: 0x170027AA RID: 10154
		// (get) Token: 0x0600AF88 RID: 44936 RVA: 0x000F8F70 File Offset: 0x000F7170
		// (set) Token: 0x0600AF89 RID: 44937 RVA: 0x000F8F84 File Offset: 0x000F7184
		public unsafe string foliage_path
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FKuroFoliageDetailCheckData.__PropertyOffset_foliage_path)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FKuroFoliageDetailCheckData.__PropertyOffset_foliage_path)), value);
			}
		}

		// Token: 0x170027AB RID: 10155
		// (get) Token: 0x0600AF8A RID: 44938 RVA: 0x000F8F99 File Offset: 0x000F7199
		// (set) Token: 0x0600AF8B RID: 44939 RVA: 0x000F8FAD File Offset: 0x000F71AD
		public unsafe string foliage_model_path
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FKuroFoliageDetailCheckData.__PropertyOffset_foliage_model_path)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FKuroFoliageDetailCheckData.__PropertyOffset_foliage_model_path)), value);
			}
		}

		// Token: 0x170027AC RID: 10156
		// (get) Token: 0x0600AF8C RID: 44940 RVA: 0x000F8FC2 File Offset: 0x000F71C2
		// (set) Token: 0x0600AF8D RID: 44941 RVA: 0x000F8FD6 File Offset: 0x000F71D6
		public unsafe string foliage_show_distance_type
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FKuroFoliageDetailCheckData.__PropertyOffset_foliage_show_distance_type)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FKuroFoliageDetailCheckData.__PropertyOffset_foliage_show_distance_type)), value);
			}
		}

		// Token: 0x0600AF8E RID: 44942 RVA: 0x000F8FEB File Offset: 0x000F71EB
		public FKuroFoliageDetailCheckData()
		{
		}

		// Token: 0x0600AF8F RID: 44943 RVA: 0x000F8FF3 File Offset: 0x000F71F3
		public FKuroFoliageDetailCheckData(string foliage_path, string foliage_model_path, string foliage_show_distance_type)
		{
			this.foliage_path = foliage_path;
			this.foliage_model_path = foliage_model_path;
			this.foliage_show_distance_type = foliage_show_distance_type;
		}

		// Token: 0x0600AF90 RID: 44944 RVA: 0x000F9010 File Offset: 0x000F7210
		protected override IntPtr GetUStructPtr()
		{
			return FKuroFoliageDetailCheckData.StaticStruct();
		}

		// Token: 0x0600AF91 RID: 44945 RVA: 0x000F901C File Offset: 0x000F721C
		[NullableContext(2)]
		public FKuroFoliageDetailCheckData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600AF92 RID: 44946 RVA: 0x000F9026 File Offset: 0x000F7226
		public FKuroFoliageDetailCheckData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600AF93 RID: 44947 RVA: 0x000F9031 File Offset: 0x000F7231
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroFoliageDetailCheckData(Pointer, false, true);
		}

		// Token: 0x0600AF94 RID: 44948 RVA: 0x000F903B File Offset: 0x000F723B
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroFoliageDetailCheckData(Pointer, MemoryOwner);
		}

		// Token: 0x04005BE7 RID: 23527
		public const string __ObjectPath = "/Script/Engine.KuroFoliageDetailCheckData";

		// Token: 0x04005BE8 RID: 23528
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04005BE9 RID: 23529
		internal static int __PropertyOffset_foliage_path;

		// Token: 0x04005BEA RID: 23530
		internal static int __PropertyOffset_foliage_model_path;

		// Token: 0x04005BEB RID: 23531
		internal static int __PropertyOffset_foliage_show_distance_type;
	}
}
