using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000488 RID: 1160
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/ClothingSystemRuntimeCommon.PointWeightMap")]
	[UnrealStructLayout(32, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 32)]
	public class FPointWeightMap : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06003E5A RID: 15962 RVA: 0x0005DD21 File Offset: 0x0005BF21
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FPointWeightMap._ScriptStructPtr != 0) ? FPointWeightMap._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/ClothingSystemRuntimeCommon.PointWeightMap", ref FPointWeightMap._ScriptStructPtr);
		}

		// Token: 0x17000F39 RID: 3897
		// (get) Token: 0x06003E5B RID: 15963 RVA: 0x0005DD48 File Offset: 0x0005BF48
		// (set) Token: 0x06003E5C RID: 15964 RVA: 0x0005DD8B File Offset: 0x0005BF8B
		public TArray<float> Values
		{
			get
			{
				base.FastCheckIsValid();
				TArray<float> result;
				if ((result = this._Values) == null)
				{
					result = (this._Values = new TArray<float>(base.NativePtr + (IntPtr)FPointWeightMap.__PropertyOffset_Values, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.Values.CopyAssign(value);
			}
		}

		// Token: 0x06003E5D RID: 15965 RVA: 0x0005DD99 File Offset: 0x0005BF99
		public FPointWeightMap()
		{
		}

		// Token: 0x06003E5E RID: 15966 RVA: 0x0005DDA1 File Offset: 0x0005BFA1
		public FPointWeightMap(TArray<float> Values, FName Name, byte CurrentTarget, bool bEnabled)
		{
			this.Values = Values;
		}

		// Token: 0x06003E5F RID: 15967 RVA: 0x0005DDB0 File Offset: 0x0005BFB0
		protected override IntPtr GetUStructPtr()
		{
			return FPointWeightMap.StaticStruct();
		}

		// Token: 0x06003E60 RID: 15968 RVA: 0x0005DDBC File Offset: 0x0005BFBC
		[NullableContext(2)]
		public FPointWeightMap(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06003E61 RID: 15969 RVA: 0x0005DDC6 File Offset: 0x0005BFC6
		public FPointWeightMap(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06003E62 RID: 15970 RVA: 0x0005DDD1 File Offset: 0x0005BFD1
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FPointWeightMap(Pointer, false, true);
		}

		// Token: 0x06003E63 RID: 15971 RVA: 0x0005DDDB File Offset: 0x0005BFDB
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FPointWeightMap(Pointer, MemoryOwner);
		}

		// Token: 0x04001D67 RID: 7527
		public const string __ObjectPath = "/Script/ClothingSystemRuntimeCommon.PointWeightMap";

		// Token: 0x04001D68 RID: 7528
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04001D69 RID: 7529
		internal static int __PropertyOffset_Values;

		// Token: 0x04001D6A RID: 7530
		[Nullable(2)]
		private TArray<float> _Values;
	}
}
