using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000798 RID: 1944
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/NavigationSystem.NavigationPath")]
	[UnrealStructLayout(152, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 152)]
	public class UNavigationPath : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600A7C1 RID: 42945 RVA: 0x000F7A10 File Offset: 0x000F5C10
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UNavigationPath._ClassPtr;
		}

		// Token: 0x0600A7C2 RID: 42946 RVA: 0x000F7A1C File Offset: 0x000F5C1C
		public UNavigationPath() : this(BuiltinUtils.AllocNativeUObject(UNavigationPath.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600A7C3 RID: 42947 RVA: 0x000F7A44 File Offset: 0x000F5C44
		public UNavigationPath(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UNavigationPath.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001F35 RID: 7989
		// (get) Token: 0x0600A7C4 RID: 42948 RVA: 0x000F7A78 File Offset: 0x000F5C78
		// (set) Token: 0x0600A7C5 RID: 42949 RVA: 0x000F7AB1 File Offset: 0x000F5CB1
		public TArray<FVector> PathPoints
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FVector> result;
				if ((result = this._PathPoints) == null)
				{
					result = (this._PathPoints = new TArray<FVector>(base.NativePtr + (IntPtr)UNavigationPath.__PropertyOffset_PathPoints, this));
				}
				return result;
			}
			set
			{
				this.PathPoints.CopyAssign(value);
			}
		}

		// Token: 0x0600A7C6 RID: 42950 RVA: 0x000F7ABF File Offset: 0x000F5CBF
		public new bool IsValid()
		{
			return UNavigationPath.__IsValid_Internal(base.NativePtr);
		}

		// Token: 0x0600A7C7 RID: 42951 RVA: 0x000F7ACC File Offset: 0x000F5CCC
		public bool IsStringPulled()
		{
			return UNavigationPath.__IsStringPulled_Internal(base.NativePtr);
		}

		// Token: 0x0600A7C8 RID: 42952 RVA: 0x000F7AD9 File Offset: 0x000F5CD9
		public bool IsPartial()
		{
			return UNavigationPath.__IsPartial_Internal(base.NativePtr);
		}

		// Token: 0x0600A7C9 RID: 42953 RVA: 0x000F7AE6 File Offset: 0x000F5CE6
		public float GetPathLength()
		{
			return UNavigationPath.__GetPathLength_Internal(base.NativePtr);
		}

		// Token: 0x0600A7CA RID: 42954 RVA: 0x000F7AF3 File Offset: 0x000F5CF3
		public float GetPathCost()
		{
			return UNavigationPath.__GetPathCost_Internal(base.NativePtr);
		}

		// Token: 0x0600A7CB RID: 42955 RVA: 0x000F7B00 File Offset: 0x000F5D00
		public string GetDebugString()
		{
			return FString.ToStringAndDeleteNativePtr(UNavigationPath.__GetDebugString_Internal(base.NativePtr));
		}

		// Token: 0x0600A7CC RID: 42956 RVA: 0x000F7B14 File Offset: 0x000F5D14
		public void EnableDebugDrawing(bool bShouldDrawDebugData, FLinearColor? PathColor = null)
		{
			UNavigationPath.__EnableDebugDrawing_Internal(base.NativePtr, bShouldDrawDebugData, PathColor ?? new FLinearColor
			{
				R = 1f,
				G = 1f,
				B = 1f,
				A = 1f
			});
		}

		// Token: 0x0600A7CD RID: 42957
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsValid_Internal(IntPtr @this);

		// Token: 0x0600A7CE RID: 42958
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsStringPulled_Internal(IntPtr @this);

		// Token: 0x0600A7CF RID: 42959
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsPartial_Internal(IntPtr @this);

		// Token: 0x0600A7D0 RID: 42960
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetPathLength_Internal(IntPtr @this);

		// Token: 0x0600A7D1 RID: 42961
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetPathCost_Internal(IntPtr @this);

		// Token: 0x0600A7D2 RID: 42962
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetDebugString_Internal(IntPtr @this);

		// Token: 0x0600A7D3 RID: 42963
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __EnableDebugDrawing_Internal(IntPtr @this, bool bShouldDrawDebugData, FLinearColor PathColor);

		// Token: 0x0600A7D4 RID: 42964 RVA: 0x000F7B79 File Offset: 0x000F5D79
		static UNavigationPath()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/NavigationSystem.NavigationPath");
		}

		// Token: 0x0600A7D5 RID: 42965 RVA: 0x000F7B87 File Offset: 0x000F5D87
		protected UNavigationPath(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040047E9 RID: 18409
		public new const string __ObjectPath = "/Script/NavigationSystem.NavigationPath";

		// Token: 0x040047EA RID: 18410
		private static IntPtr _ClassPtr;

		// Token: 0x040047EB RID: 18411
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040047EC RID: 18412
		internal static int __PropertyOffset_PathPoints;

		// Token: 0x040047ED RID: 18413
		[Nullable(2)]
		private TArray<FVector> _PathPoints;
	}
}
