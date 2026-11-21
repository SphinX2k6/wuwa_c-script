using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000042 RID: 66
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public sealed class UnrealScriptStructProxyArrayProcessor<[Nullable(0)] T> : NativeArrayProcessorBase<T>, IScriptStructProcessor where T : UnrealScriptStructProxy, IUnrealScriptStructProxy, new()
	{
		// Token: 0x0600088D RID: 2189 RVA: 0x0000D8C4 File Offset: 0x0000BAC4
		public UnrealScriptStructProxyArrayProcessor()
		{
			this.IsStructProxyProcessor = true;
			this.RequireConstructAndDestruct = true;
			this.HasGetTypeHash = typeof(T).IsDefined(typeof(HasGetTypeHashAttribute));
			int num;
			UnrealReflectionUtils.GetUScriptStructProps(IUnrealScriptStruct.StaticStruct(), out this.Size, out this.MinAlignment, out num);
		}

		// Token: 0x0600088E RID: 2190 RVA: 0x0000D922 File Offset: 0x0000BB22
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public UScriptStructStackOnlyPtr GetNativeScriptStructPtr()
		{
			return IUnrealScriptStruct.StaticStruct();
		}

		// Token: 0x0600088F RID: 2191 RVA: 0x0000D92F File Offset: 0x0000BB2F
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public override T Get(IntPtr Data, int Index)
		{
			return IUnrealScriptStructProxy.CreateFromPointer(Data + (IntPtr)(Index * this.Size)) as T;
		}

		// Token: 0x06000890 RID: 2192 RVA: 0x0000D951 File Offset: 0x0000BB51
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public override T GetRef_Unsafe(IntPtr Data, int Index, UnrealObject Caller)
		{
			return IUnrealScriptStructProxy.CreateReferenceFromPointer(Data + (IntPtr)(Index * this.Size), Caller) as T;
		}

		// Token: 0x06000891 RID: 2193 RVA: 0x0000D974 File Offset: 0x0000BB74
		[NullableContext(2)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public override void Set(IntPtr Data, int Index, T Value)
		{
			SharpherealAssert.Assert(Value != null, "Struct Value is null");
			UnrealReflectionUtils.CopyNativeStruct(IUnrealScriptStruct.StaticStruct(), Data + (IntPtr)(Index * this.Size), Value._NativePtr, 1, false);
		}

		// Token: 0x06000892 RID: 2194 RVA: 0x0000D9B4 File Offset: 0x0000BBB4
		[NullableContext(2)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public override int FindIndex(IntPtr Data, int Num, T Value)
		{
			SharpherealAssert.Assert(Value != null, "Struct Value is null");
			return UnrealReflectionUtils.FindNativeStructIndexInArray(IUnrealScriptStruct.StaticStruct(), Data, Value._NativePtr, Num);
		}

		// Token: 0x06000893 RID: 2195 RVA: 0x0000D9E9 File Offset: 0x0000BBE9
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public unsafe override void ConstructValues(IntPtr Data, int Index, int Count)
		{
			UnrealReflectionUtils.InitializeStruct(IUnrealScriptStruct.StaticStruct(), (void*)(Data + (byte*)((IntPtr)(Index * this.Size))), Count);
		}

		// Token: 0x06000894 RID: 2196 RVA: 0x0000DA07 File Offset: 0x0000BC07
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public unsafe override void DestructValues(IntPtr Data, int Index, int Count)
		{
			UnrealReflectionUtils.DestroyStruct(IUnrealScriptStruct.StaticStruct(), (void*)(Data + (byte*)((IntPtr)(Index * this.Size))), Count);
		}

		// Token: 0x06000895 RID: 2197 RVA: 0x0000DA25 File Offset: 0x0000BC25
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public override void CopyTo(IntPtr Data, IntPtr Dest, int Num)
		{
			UnrealReflectionUtils.CopyNativeStruct(IUnrealScriptStruct.StaticStruct(), Dest, Data, Num, true);
		}

		// Token: 0x06000896 RID: 2198 RVA: 0x0000DA3B File Offset: 0x0000BC3B
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public unsafe override void* GetElementPtr([Nullable(1)] ref T Value, ref bool bRequireToDelete)
		{
			return Value._NativePtr;
		}
	}
}
