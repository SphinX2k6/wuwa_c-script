using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000CF1 RID: 3313
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.KuroMaterialDetailCheckData")]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 16)]
	public class FKuroMaterialDetailCheckData : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600AFD8 RID: 45016 RVA: 0x000F9626 File Offset: 0x000F7826
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroMaterialDetailCheckData._ScriptStructPtr != 0) ? FKuroMaterialDetailCheckData._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.KuroMaterialDetailCheckData", ref FKuroMaterialDetailCheckData._ScriptStructPtr);
		}

		// Token: 0x170027C0 RID: 10176
		// (get) Token: 0x0600AFD9 RID: 45017 RVA: 0x000F964A File Offset: 0x000F784A
		// (set) Token: 0x0600AFDA RID: 45018 RVA: 0x000F965E File Offset: 0x000F785E
		public unsafe string mat_path
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)FKuroMaterialDetailCheckData.__PropertyOffset_mat_path)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)FKuroMaterialDetailCheckData.__PropertyOffset_mat_path)), value);
			}
		}

		// Token: 0x0600AFDB RID: 45019 RVA: 0x000F9673 File Offset: 0x000F7873
		public FKuroMaterialDetailCheckData()
		{
		}

		// Token: 0x0600AFDC RID: 45020 RVA: 0x000F967B File Offset: 0x000F787B
		public FKuroMaterialDetailCheckData(string mat_path)
		{
			this.mat_path = mat_path;
		}

		// Token: 0x0600AFDD RID: 45021 RVA: 0x000F968A File Offset: 0x000F788A
		protected override IntPtr GetUStructPtr()
		{
			return FKuroMaterialDetailCheckData.StaticStruct();
		}

		// Token: 0x0600AFDE RID: 45022 RVA: 0x000F9696 File Offset: 0x000F7896
		[NullableContext(2)]
		public FKuroMaterialDetailCheckData(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600AFDF RID: 45023 RVA: 0x000F96A0 File Offset: 0x000F78A0
		public FKuroMaterialDetailCheckData(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600AFE0 RID: 45024 RVA: 0x000F96AB File Offset: 0x000F78AB
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroMaterialDetailCheckData(Pointer, false, true);
		}

		// Token: 0x0600AFE1 RID: 45025 RVA: 0x000F96B5 File Offset: 0x000F78B5
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroMaterialDetailCheckData(Pointer, MemoryOwner);
		}

		// Token: 0x04005C0E RID: 23566
		public const string __ObjectPath = "/Script/Engine.KuroMaterialDetailCheckData";

		// Token: 0x04005C0F RID: 23567
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04005C10 RID: 23568
		internal static int __PropertyOffset_mat_path;
	}
}
